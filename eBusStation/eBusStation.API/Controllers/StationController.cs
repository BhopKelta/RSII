using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class StationController : ApiController
    {
        private eBusStation_Entities _database;
        public StationController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/Station/GetStation")]
        public int? GetStation(int cityId)
        {
           return _database.Get_Station_By_City(cityId).FirstOrDefault();
        }
    }
}
