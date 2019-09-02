using HomeOwnerBestie.Common;
using System;

namespace HomeOwnerBestie.LeadData.DataManager
{
    public interface ILeadDataManager
    {
        string AddUser(HOBAppUser user);
        string AddRentValuationRecord(HOBAppUser user, Address address, RentValuationData rentValuationData);
        string UpdateHomeOwnerSpecifiedRent(string userId, decimal homeOwnerSpecifiedRent);
        RentValuationData FindRentValuationRecord(string updatedRentValuationRecord);
        Address GetAddressFromRentValuationRecordId(string updatedRentValuationRecord);
        string GetUserIdFromEmail(string email);
    }
}
