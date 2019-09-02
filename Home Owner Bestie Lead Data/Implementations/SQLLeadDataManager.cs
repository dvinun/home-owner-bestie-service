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
            }
            return null;
        }
    }
}
