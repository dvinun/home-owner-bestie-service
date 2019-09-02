using System;
using System.Collections.Generic;

namespace HomeOwnerBestie.LeadData.SQL.Models
{
    public partial class UserIpaddresses
    {
        public string UserId { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string IpaddressRecordId { get; set; }

        public virtual AppUsers User { get; set; }
    }
}
