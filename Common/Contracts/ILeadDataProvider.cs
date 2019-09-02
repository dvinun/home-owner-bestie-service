using HomeOwnerBestie.Common;
using System;

namespace HomeOwnerBestie.LeadData.DataProvider
{
    public interface ILeadDataProvider
    {
        string AddUser(HOBAppUser user);
        string AddRentValuationRecord(HOBAppUser user, Address address, RentValuationData rentValuationData);
        string UpdateHomeOwnerSpecifiedRent(string userId, decimal homeOwnerSpecifiedRent);
        RentValuationData FindRentValuationRecord(string updatedRentValuationRecord);
        Address GetAddressFromRentValuationRecordId(string rentValuationRecordId);
        string GetUserIdFromEmail(string email);
    }
}
