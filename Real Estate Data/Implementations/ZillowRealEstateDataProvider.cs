using System;
using HomeOwnerBestie.Common;
using Microsoft.Extensions.Configuration;

namespace HomeOwnerBestie.RealEstateData.DataProvider
{
    public class ZillowRealEstateDataProvider : IRealEstateDataProvider
    {
        public ZillowRealEstateDataProvider(IConfiguration configuration)
        {
        }

        public int AddUser(HOBAppUser user)
        {
            return 1;
        }
    }
}
