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

        public int AddUser(HOBAppUser user)
        {
            return 1;
        }
    }
}
