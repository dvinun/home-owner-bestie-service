using System;
using System.Collections.Generic;

namespace HomeOwnerBestie.LeadData.SQL.Models
{
    public partial class RentValuationReports
    {
        public decimal? AverageMonthlyRent { get; set; }
        public decimal? ValueChangedIn30Days { get; set; }
        public decimal? ValuationRentHigh { get; set; }
        public decimal? ValuationRentLow { get; set; }
        public bool? IsRentEstimateAvailable { get; set; }
        public string UserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public decimal? HomeOwnerSpecifiedRent { get; set; }
        public string RentValuationRecordId { get; set; }

        public virtual AppUsers User { get; set; }
    }
}
