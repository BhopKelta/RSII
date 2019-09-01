using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eBusStation.API.JsonModels;

namespace eBusStation.API.Controllers
{
    public class RecensionController : ApiController
    {
        private eBusStation_Entities _database;
        public RecensionController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/Recension/LoadRates/{relationId}")]
        public List<usp_mobile_Recommender_Load_Rates_Result>LoadRatesForRelation(int relationId)
        {
            return _database.usp_mobile_Recommender_Load_Rates(relationId).ToList();
        }
        [HttpPost]
        [Route("api/Recension/AddRecension")]
        public IHttpActionResult AddNewRecension([FromBody]RecensionModel recension)
        {
            int? counterOfCurrentRecesnsion = _database.usp_mobile_Check_For_Recension_It_Exists(recension.KartaId).First();

            if (counterOfCurrentRecesnsion.HasValue)
            {
                if (counterOfCurrentRecesnsion.Value > 0)
                {
                    return NotFound();
                }
            }
            _database.usp_mobile_Add_User_Recension(recension.KartaId, recension.KlijentiId, recension.Ocjena, recension.Komentar);
            return Ok();
        }
    }
}
