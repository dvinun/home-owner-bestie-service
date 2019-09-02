using Common.DataStructures;
using HomeOwnerBestie.Common;
using HomeOwnerBestie.LeadData.DataManager;
using HomeOwnerBestie.RealEstateData.DataProvider;
using Newtonsoft.Json;
using System;

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

            var jsonRentValuationData = JsonConvert.SerializeObject(rentValuationData);
            var jsonAddress = JsonConvert.SerializeObject(address);

            EmailEnvelop emailEnvelope = new EmailEnvelop()
            {
                Body = "Congratulations on your signup!" +
                        Environment.NewLine + Environment.NewLine  + " Here are the data we collected from you." + 
                        jsonRentValuationData + Environment.NewLine + Environment.NewLine + Environment.NewLine + jsonAddress,
                From = "agilepointtesting001@gmail.com",
                To = user.Email,
                Subject = $"Hello {user.FirstName}! Your Home Rent Valuation Info",
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
