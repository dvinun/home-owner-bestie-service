using System;
using System.Collections.Generic;

namespace HomeOwnerBestie.LeadData.SQL.Models
{
    public partial class UserAddresses
    {
        public string UserId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
        public string AddressId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string State { get; set; }

        public virtual AppUsers User { get; set; }
    }
}
