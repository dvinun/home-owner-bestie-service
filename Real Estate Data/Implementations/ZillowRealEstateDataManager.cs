using HomeOwnerBestie.Common;
using HomeOwnerBestie.RealEstateData.DataProvider;
using System;

namespace HomeOwnerBestie.RealEstateData.DataManager
{
    public class ZillowRealEstateDataManager : IRealEstateDataManager
    {
        IRealEstateDataProvider realEstateDataProvider = null;

        public ZillowRealEstateDataManager(IRealEstateDataProvider realEstateDataProvider)
        {
            this.realEstateDataProvider = realEstateDataProvider;
        }

        public int AddUser(HOBAppUser user)
        {
            return 1;
        }

    }
}
