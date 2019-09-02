using HomeOwnerBestie.Common;
using System;

namespace HomeOwnerBestie.RealEstateData.DataManager
{
    public interface IRealEstateDataManager
    {
        RentValuationData RunRentEvaluation(HOBAppUser user, Address address);
        bool EmailRentValuationReport(HOBAppUser user, decimal homeOwnerSpecifiedRent);
    }
}
