using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.API.JsonModels
{
    public class EditNotificationModel
    {
        public string notificationText { get; set; }
        public string table { get; set; }
        public string Id { get; set; }
    }
}
