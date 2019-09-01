using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class TravelerController : ApiController
    {
        private eBusStation_Entities _database;
        public TravelerController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/Traveler/Index")]
        public List<usp_Get_Travelers_Result> GetTravelers()
        {
            return _database.Get_Travelers().ToList();
        }
    }
}
