using eBusStation.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class BusController : ApiController
    {
        private eBusStation_Entities _database;
        public BusController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/Bus/AllBuses")]
        public List<Get_All_Bus_Names_Result> GetAllBuses()
        {
            return _database.Get_All_Bus_Names().ToList();
        }
        [Route("api/Bus/GetTypesOfBuses")]
        public List<usp_Get_Types_Of_Buses_Result> GetTypeOfBuses()
        {
            return _database.Get_Types_Of_Buses().ToList();
        }
        [HttpGet]
        [Route("api/Bus/SearchBuses")]
        public List<usp_Search_Buses_Result> SearchBuses(string travelerId,string typeOfBusId)
        {
            return _database.Search_Buses(Convert.ToInt32(travelerId), Convert.ToInt32(typeOfBusId)).ToList();
        }
        [HttpGet]
        [Route("api/Bus/{lineId}/GetBus")]
        public List<usp_mobile_Get_Buses_Information_Result> GetBus(int lineId)
        {
           return _database.usp_mobile_Get_Buses_Information(lineId).ToList();
        }
        [HttpPost]
        [Route("api/Bus/RememberBusCameOnStation")]
        public IHttpActionResult BusCameOnStation([FromBody]SaobracajniDnevnik diary)
        {
            _database.Add_Coming_Bus_On_Station(diary.UposlenikId, diary.StanicaId, diary.vrijemeKasnjena, diary.vrijemeDolaska, diary.daLiJeKansnio);
            return Ok();
        }
        [HttpPost]
        [Route("api/Bus/AddPicture")]
        public IHttpActionResult AddPicture([FromBody]Autobusi bus)
        {
            _database.Add_Bus_Picture(bus.slikaAutobusa, bus.Id);
            return Ok();
        }
        [HttpPost]
        [Route("api/Bus/AddNewBus")]
        public IHttpActionResult AddBus([FromBody]Autobusi bus)
        {
            _database.usp_Add_Bus(bus.brojSjedistaBusa, bus.Proizvodjac, bus.VrstaAutobusaId, bus.RegOznake);
            return Ok();
        }
    }
}
