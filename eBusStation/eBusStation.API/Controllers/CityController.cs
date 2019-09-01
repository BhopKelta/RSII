using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class CityController : ApiController
    {
        private eBusStation_Entities _database;
        public CityController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/City/Index")]
        public List<usp_Get_All_Cities_Result> GetAllCites()
        {
            return _database.Get_All_Cities().ToList();
        }
    }
}
