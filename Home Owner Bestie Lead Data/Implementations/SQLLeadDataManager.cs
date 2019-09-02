using HomeOwnerBestie.Common;
using HomeOwnerBestie.LeadData.DataProvider;
using System;

namespace HomeOwnerBestie.LeadData.DataManager
{
    public class SQLLeadDataManager : ILeadDataManager
    {
        ILeadDataProvider leadDataProvider = null;

        public SQLLeadDataManager(ILeadDataProvider leadDataProvider)
        {
            this.leadDataProvider = leadDataProvider;
        }

        public string AddUser(HOBAppUser user)
        {
            try
            {
                return leadDataProvider.AddUser(user);
            }
            catch (Exception ex)
            {
                //TBD
                return null;
            }
        }

        public string AddRentValuationRecord(HOBAppUser user, Address address, RentValuationData rentValuationData)
        {
            try
            {
                return leadDataProvider.AddRentValuationRecord(user, address, rentValuationData);
            }
            catch (Exception ex)
            {
                //TBD
                return null;
            }
        }

        public string UpdateHomeOwnerSpecifiedRent(string userId, decimal homeOwnerSpecifiedRent)
        {
            return leadDataProvider.UpdateHomeOwnerSpecifiedRent(userId, homeOwnerSpecifiedRent);
        }

        public RentValuationData FindRentValuationRecord(string updatedRentValuationRecord)
        {
            return leadDataProvider.FindRentValuationRecord(updatedRentValuationRecord);
        }

        public Address GetAddressFromRentValuationRecordId(string rentValuationRecordId)
        {
            return leadDataProvider.GetAddressFromRentValuationRecordId(rentValuationRecordId);
        }

        public string GetUserIdFromEmail(string email)
        {
            return leadDataProvider.GetUserIdFromEmail(email);
        }

    }
}
