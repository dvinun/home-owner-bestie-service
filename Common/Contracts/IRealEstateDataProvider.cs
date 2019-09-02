using HomeOwnerBestie.Common;
using System;

namespace HomeOwnerBestie.RealEstateData.DataProvider
{
    public interface IRealEstateDataProvider
    {
        RentValuationData RunRentEvaluation(Address address);
    }
}
