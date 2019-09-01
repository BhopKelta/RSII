using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class User_Transactions_Model
    {
        public string Status { get; set; }
        public float UkupnaCijena { get; set; }
        public string datumPutovanja { get; set; }
        public string vrijemePolaska { get; set; }
        public string datumKupovine { get; set; }
        public string Destinacija { get; set; }
        public string VrijemeDolaska { get; set; }
        public int Id { get; set; }
        public int KartaId { get; set; }
    }
}
