using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Transaction_Model
    {
        public int Id { get; set; }
        public System.DateTime datumKupovine { get; set; }
        public string brojTransakcije { get; set; }
        public string Status { get; set; }
        public bool otkazano { get; set; }
        public int KlijentiId { get; set; }
        public int KarticaId { get; set; }
    }
}
