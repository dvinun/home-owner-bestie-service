using HomeOwnerBestie.Common;
using Microsoft.Extensions.Configuration;
using System;

namespace HomeOwnerBestie.LeadData.DataProvider
{
    public class SQLLeadDataProvider : ILeadDataProvider
    {
        public SQLLeadDataProvider(IConfiguration configuration)
        {
        }

        public int AddUser(HOBAppUser user)
        {
            return 1;
        }
    }
}
