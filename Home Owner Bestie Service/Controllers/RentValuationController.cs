using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeOwnerBestie.Common;
using HomeOwnerBestie.RealEstateData.DataManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeOwnerBestieService.Controllers
{
    [Route("rentvaluation")]
    [Produces("application/json")]
    [ApiController]
    public class RentValuationController : ControllerBase
    {
        private readonly IRealEstateDataManager realEstateDataManager;

        public RentValuationController(IRealEstateDataManager realEstateDataManager)
        {
            this.realEstateDataManager = realEstateDataManager;
        }

        public class RentValuationParam
        {
            public HOBAppUser user { get; set; }
            public Address address { get; set; }
        }

        [HttpPost]
        public RentValuationData RentValuation([FromBody] RentValuationParam input)
        {
            return realEstateDataManager.RunRentEvaluation(input.user, input.address);
        }

        public class EmailRentValuationParam
        {
            public HOBAppUser user { get; set; }
            public decimal homeOwnerSpecifiedRent { get; set; }
        }

        [HttpPost("emailme")]
        public bool Email([FromBody] EmailRentValuationParam input)
        {
            return realEstateDataManager.EmailRentValuationReport(input.user, input.homeOwnerSpecifiedRent);
        }

    }
}
