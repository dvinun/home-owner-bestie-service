using System;

namespace HomeOwnerBestie.Common
{
    public class RentValuationData
    {
        public decimal AverageMonthlyRent { get; set; }
        public decimal ValueChangedIn30Days { get; set; }
        public decimal ValuationRentHigh { get; set; }
        public decimal ValuationRentLow { get; set; }
        public bool IsRentEstimateAvailable { get; set; }
    }
}
