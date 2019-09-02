using HomeOwnerBestie.Common;
using System;

namespace HomeOwnerBestie.LeadData.DataProvider
{
    public interface ILeadDataProvider
    {
        int AddUser(HOBAppUser user);

    }
}
