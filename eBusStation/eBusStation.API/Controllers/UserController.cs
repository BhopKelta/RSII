using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class UserController : ApiController
    {
        private eBusStation_Entities _database;
        public UserController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/User/GetUserCards/{userId}")]
        public List<usp_mobile_Get_User_Credit_Cards_Result>GetCards(int userId)
        {
            return _database.usp_mobile_Get_User_Credit_Cards(userId).ToList();
        }
    }
}
