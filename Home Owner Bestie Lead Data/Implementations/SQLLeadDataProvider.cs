using HomeOwnerBestie.Common;
using HomeOwnerBestie.LeadData.SQL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace HomeOwnerBestie.LeadData.DataProvider
{
    public class SQLLeadDataProvider : ILeadDataProvider
    {
        HomeOwnerBestieDBContext homeOwnerBestieDBContext = null;

        public SQLLeadDataProvider(HomeOwnerBestieDBContext homeOwnerBestieDBContext)
        {
            this.homeOwnerBestieDBContext = homeOwnerBestieDBContext;
        }

        public string AddUser(HOBAppUser user)
        {
            var resultUser = homeOwnerBestieDBContext.AppUsers
                        .Where(item => item.Email == user.Email)
                        .First();

            // update
            if (resultUser != null)
            {
                resultUser.DateModified = DateTime.Now;
                resultUser.FirstName = user.FirstName;
                resultUser.LastName = user.LastName;
                resultUser.Phone = user.Phone;
                homeOwnerBestieDBContext.SaveChanges();
                return resultUser.UserId;
            }
            else
            {
                var newGuid = Guid.NewGuid().ToString();
                homeOwnerBestieDBContext.AppUsers.Add(new AppUsers()
                {
                    DateCreated = DateTime.Now,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Phone = user.Phone,
                    UserId = newGuid
                });
                homeOwnerBestieDBContext.SaveChanges();
                return newGuid;
            }
        }
    }
}
