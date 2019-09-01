using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class BusCardController : ApiController
    {
        private eBusStation_Entities _database;
        public BusCardController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpPost]
        [Route("api/BusCard/AddCard")]
        public decimal? AddNewCard([FromBody]Karte card)
        {
            return _database.usp_mobile_Add_User_Travel(card.Aktivna, card.BrojKarte, card.brojSjedista, card.datumPutovanja, card.PosjecujeLokacijeId, card.TipKarteId).First();
        }
    }
}
