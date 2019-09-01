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
    public class NotificationController : ApiController
    {
        private eBusStation_Entities _database;

        public NotificationController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpPost]
        [Route("api/Notification/AddInfo")]
        public IHttpActionResult AddInformation([FromBody]Obavijesti notification)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _database.Add_Info_Notification(notification.LinijaId, notification.Tekst);
            return Ok();
        }
        [HttpGet]
        [Route("api/Notification/Index")]
        public List<usp_Get_All_Notifications_Result> GetNotifications()
        {
            return _database.Get_All_Notifications().ToList();
        }
        [HttpPost]
        [Route("api/Notification/EditInfo")]
        public IHttpActionResult EditInformation([FromBody]EditNotificationModel model)
        {
            _database.Edit_Notification(model.table, model.notificationText, Convert.ToInt32(model.Id));
            return Ok();
        }
    }
}
