using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eBusStation.API.Static;

namespace eBusStation.API.Controllers
{
    public class RelationController : ApiController
    {
        private eBusStation_Entities _database;

        public RelationController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/Relation/GetLineEarning")]
        public List<usp_Get_Line_Earnings_Result>LineEarning()
        {
            return _database.Get_Line_Earnings().ToList();
        }
        [HttpGet]
        [Route("api/Relation/GetLineReservationCounter")]
        public List<usp_Get_Reservation_Counter_On_Line_Result> GetReservationCounter()
        {
            return _database.Get_Reservation_Counter_On_Line().ToList();
        }
        [HttpGet]
        [Route("api/Relation/RecommendRelations/{relationId}")]
        public List<usp_mobile_Get_Cite_That_Line_Pass_By_Id_Result> Recommend(int relationId)
        {
            Recommender recommend = new Recommender();
            return recommend.GetSimilarRelations(relationId);
        }
        [HttpGet]
        [Route("api/Relation/LoadRelationsDifferentThanCurrent/{relationId}")]
        public List<usp_mobile_Recommnder_Load_Relations_Different_Than_Current_Result>
            GetRelationsDifferentThanCurrent(int relationId)
        {
            return _database.usp_mobile_Recommnder_Load_Relations_Different_Than_Current(relationId).ToList();
        }
        [HttpGet]
        [Route("api/Relation/Index")]
        public List<usp_Get_All_Relations_Result> GetRelations()
        {
            return _database.Get_All_Relations().ToList();
        }
        [HttpGet]
        [Route("api/Relation/RelationWithTraveler")]
        public List<usp_Get_Lines_With_Traveler_Result> GetRelationsWithTraveler()
        {
            return _database.Get_Lines_With_Traveler().ToList();
        }
        [HttpGet]
        [Route("api/Relation/{lineId}/Cities")]
        public List<usp_Get_Cities_That_Line_Passes_Result> GetCitiesPassing(int lineId)
        {
            return _database.Get_Cities_That_Line_Passes(lineId).ToList();
        }
        [HttpGet]
        [Route("api/Relation/Citie/{relationId}")]
        public usp_Get_Cities_That_Line_Passes_Result GetCitie(int relationId)
        {
            return _database.usp_mobile_Get_Cite_That_Line_Pass_By_Id(relationId).FirstOrDefault();
        }
        [HttpGet]
        [Route("api/Relation/SearchLines")]
        public List<usp_mobile_Search_Lines_Result> Search(string start, string end, string traveler, string startTime, string endTime)
        {
            return _database.usp_mobile_Search_Lines(start, end, traveler, startTime, endTime).ToList();
        }
        [HttpGet]
        [Route("api/Relation/GetAvailablePlacesAtDate")]
        public List<usp_mobile_Get_Available_Places_Bus_At_Date_Result> GetPlaces(string date)
        {
            return _database.usp_mobile_Get_Available_Places_Bus_At_Date(date).ToList();
        }
        [HttpGet]
        [Route("api/Relation/GetSpecificOffer/{offerId}")]
        public usp_mobile_Get_Relation_Offer_Information_Result GetOffer(int offerId)
        {
            return _database.usp_mobile_Get_Relation_Offer_Information(offerId).FirstOrDefault();
        }

        [HttpPost]
        [Route("api/Relation/MakeRelationUnActive/{id}")]
        public IHttpActionResult UnActiveRelation([FromBody]int id)
        {
            _database.Make_Relation_Un_Active(id);
            return Ok();
        }
        [HttpPost]
        [Route("api/Relation/EditRelation")]
        public IHttpActionResult UpdateRelation([FromBody]Linije line)
        {
            _database.Edit_Relation(line.Id, line.PolazakId, line.DestinacijaId, line.Naziv, line.PrevoznikId, line.TipLinije, line.vrijemePolaska);
            return Ok();
        }
        [HttpPost]
        [Route("api/Relation/AddRelation")]
        public IHttpActionResult AddRelation([FromBody]Linije line)
        {
            _database.Add_Relation(line.PolazakId, line.DestinacijaId, line.Naziv, line.PrevoznikId, line.TipLinije, line.vrijemePolaska);
            return Ok();
        }
        [HttpPost]
        [Route("api/Relation/AddCityPassingLine")]
        public IHttpActionResult AddCityPassing([FromBody]PosjecujeLokacije city)
        {
            _database.Add_City_That_Line_Pass(city.LinijeId, city.cijenaOdPolaska,
                city.GradId, city.vrijemeDolaska, city.IsDeleted, city.CijenaOdTrenutnogGradaDoDestinacije, city.isStudentska);
            return Ok();
        }
        [HttpPost]
        [Route("api/Relation/EditCityPassingLine")]
        public IHttpActionResult UpdateCityPassingThroughLine([FromBody]PosjecujeLokacije city)
        {
            _database.Update_City_That_Line_Pass(city.LinijeId, city.Id, city.cijenaOdPolaska,
                city.GradId, city.vrijemeDolaska, city.IsDeleted, city.CijenaOdTrenutnogGradaDoDestinacije, city.isStudentska);
            return Ok();
        }
        [HttpPost]
        [Route("api/Relation/MakeOrderOfLineUnActive/{id}")]
        public IHttpActionResult DeleteCityPassingThroughLine([FromBody]int cityLineId)
        {
            _database.Delete_City_That_Line_Pass(cityLineId);
            return Ok();
        }
    }
}
