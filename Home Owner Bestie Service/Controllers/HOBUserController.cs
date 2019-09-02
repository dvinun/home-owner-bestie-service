using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeOwnerBestie.Common;
using HomeOwnerBestie.LeadData.DataManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeOwnerBestieService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class HOBUserController : ControllerBase
    {
        private readonly ILeadDataManager leadDataManager;

        public HOBUserController(ILeadDataManager leadDataManager)
        {
            this.leadDataManager = leadDataManager;
        }

        // GET: api/HOBUser
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HOBUser/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/HOBUser
        [HttpPost]
        public string Post([FromBody] HOBAppUser user)
        {
            return leadDataManager.AddUser(user);
        }

        // PUT: api/HOBUser/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
