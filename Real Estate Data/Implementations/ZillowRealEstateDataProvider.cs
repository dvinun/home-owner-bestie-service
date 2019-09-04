using System;
using System.IO;
using System.Xml;
using HomeOwnerBestie.Common;
using HomeOwnerBestie.RealEstateData.Zillow;
using Microsoft.Extensions.Configuration;
using ServiceStack;

namespace HomeOwnerBestie.RealEstateData.DataProvider
{
    public class ZillowRealEstateDataProvider : IRealEstateDataProvider
    {
        string mApiKey = string.Empty;
        string mApiUrl = string.Empty;

        public ZillowRealEstateDataProvider(IConfiguration configuration)
        {
            mApiUrl = configuration["RealEstateData:DataProvider:ServiceUrl"];
            mApiKey = configuration["RealEstateData:DataProvider:APIKey"];
        }

        public RentValuationData RunRentEvaluation(Address address)
        {
            if (address == null) return null;

            string url = $"{mApiUrl}?zws-id={mApiKey}&address={address.Street}&citystatezip={address.City}+{address.State}+{address.Zip}&rentzestimate=true";

            // GET data from api & map to Poco
            var response = url.GetJsonFromUrl();

            bool isNoMatchFound = response.IndexOf("no exact match") > 0;
            bool isError = (response.IndexOf("Error") > 0 || response.IndexOf("error") > 0);

            if (isNoMatchFound) return new RentValuationData() { Message = "No Match Found" };
            else if (isError) return new RentValuationData() { Message = "Zillow API Encountered Some Unknown Error" };
            else
            {
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(searchresults));
                searchresults searchresults;
                using (StringReader sr = new StringReader(response))
                {
                    searchresults = (searchresults)ser.Deserialize(sr);
                }

                var rentZestimateResults = searchresults?.response?.results;
                var zestimateResults = searchresults?.response?.results;

                // get the last result set. Because, the last result is always the latest.
                var rentZestimate = rentZestimateResults[rentZestimateResults.Length-1].rentzestimate;
                var zestimate = zestimateResults[zestimateResults.Length - 1].zestimate;

                RentValuationData rentValuationData = new RentValuationData();

                if (rentZestimate != null)
                {
                    rentValuationData.AverageMonthlyRent = Convert.ToDecimal(rentZestimate.amount.Value);
                    rentValuationData.ValueChangedIn30Days = Convert.ToDecimal(rentZestimate.valueChange.Value);
                    rentValuationData.ValuationRentLow = Convert.ToDecimal(rentZestimate.valuationRange.low.Value);
                    rentValuationData.ValuationRentHigh = Convert.ToDecimal(rentZestimate.valuationRange.high.Value);
                    rentValuationData.IsRentEstimateAvailable = true;
                }
                else if (zestimate != null)
                {
                    if(Convert.ToDecimal(zestimate.amount.Value) == 0) 
                        return new RentValuationData() { Message = "No Data Found" };

                    rentValuationData.AverageMonthlyRent = Decimal.Multiply(Convert.ToDecimal(zestimate.amount.Value), 0.05M);
                    rentValuationData.ValueChangedIn30Days = 0;
                    rentValuationData.ValuationRentHigh = Decimal.Multiply(Convert.ToDecimal(zestimate.amount.Value), 0.1M);
                    rentValuationData.ValuationRentLow = Decimal.Multiply(Convert.ToDecimal(zestimate.amount.Value), 0.1M);
                    rentValuationData.IsRentEstimateAvailable = false;
                }

                return rentValuationData;
            }
        }
    }
}


