using System;
using System.Collections.Generic;

namespace HomeOwnerBestie.LeadData.SQL.Models
{
    public partial class AppUsers
    {
        public AppUsers()
        {
            RentValuationReports = new HashSet<RentValuationReports>();
            UserAddresses = new HashSet<UserAddresses>();
            UserIpaddresses = new HashSet<UserIpaddresses>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<RentValuationReports> RentValuationReports { get; set; }
        public virtual ICollection<UserAddresses> UserAddresses { get; set; }
        public virtual ICollection<UserIpaddresses> UserIpaddresses { get; set; }
    }
}
