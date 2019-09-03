using Common.DataStructures;
using HomeOwnerBestie.Common;
using HomeOwnerBestie.LeadData.DataManager;
using HomeOwnerBestie.RealEstateData.DataProvider;
using Newtonsoft.Json;
using System;
using System.Reflection;

namespace HomeOwnerBestie.RealEstateData.DataManager
{
    public class ZillowRealEstateDataManager : IRealEstateDataManager
    {
        IRealEstateDataProvider realEstateDataProvider = null;
        ILeadDataManager leadDataManager;

        public ZillowRealEstateDataManager(IRealEstateDataProvider realEstateDataProvider, ILeadDataManager leadDataManager)
        {
            this.realEstateDataProvider = realEstateDataProvider;
            this.leadDataManager = leadDataManager;
        }

        public RentValuationData RunRentEvaluation(HOBAppUser user, Address address)
        {
            RentValuationData rentValuationData = realEstateDataProvider.RunRentEvaluation(address);
            if (rentValuationData == null || rentValuationData.AverageMonthlyRent == 0) return rentValuationData;

            string rentValuationRecordId = leadDataManager.AddRentValuationRecord(user, address, rentValuationData);
            if (string.IsNullOrWhiteSpace(rentValuationRecordId)) return null;

            return rentValuationData;
        }

        public bool EmailRentValuationReport(HOBAppUser user, decimal homeOwnerSpecifiedRent)
        {
                string userId = this.leadDataManager.GetUserIdFromEmail(user.Email);
                string updatedRentValuationRecord = this.leadDataManager.UpdateHomeOwnerSpecifiedRent(userId, homeOwnerSpecifiedRent);
                RentValuationData rentValuationData = this.leadDataManager.FindRentValuationRecord(updatedRentValuationRecord);
                Address address = this.leadDataManager.GetAddressFromRentValuationRecordId(updatedRentValuationRecord);

                var jsonUser = JsonConvert.SerializeObject(user);
                var jsonRentValuationData = JsonConvert.SerializeObject(rentValuationData);
                var jsonAddress = JsonConvert.SerializeObject(address);

                EmailEnvelop emailEnvelope = new EmailEnvelop()
                {
                    Body = "<h1>Congratulations on your signup!</h1>"
                            + "<hr/>"
                            + "<h2>Here is the data we have collected from you.</h2>"
                            + "<h3>User Info</h3>"
                            + jsonUser
                            + "<h3>Rent Valuation Data</h3>"
                            + jsonRentValuationData
                            + "<h3>Home Address</h3>"
                            + jsonAddress
                            + "<h4>Thank you. Visit us again!</h4>"
                            + "<h5>Best wishes from Home Owner Bestie Team :-)</h5>",
                    From = "agilepointtesting001@gmail.com",
                    To = user.Email,
                    Subject = $"Hello {user.FirstName}! Your Home Rent Valuation Info is now ready.",
                };

                EmailConfig emailConfig = new EmailConfig()
                {
                    Password = "pass@word1",
                    Port = 587,
                    Smtp = "smtp.gmail.com",
                    UserName = "agilepointtesting001@gmail.com"
                };

                return Utils.SendEmail(emailEnvelope, emailConfig);
        }


    }
}
