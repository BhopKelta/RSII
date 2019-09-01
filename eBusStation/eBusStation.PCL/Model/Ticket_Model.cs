using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Ticket_Model
    {
        public int Id { get; set; }
        public string BrojKarte { get; set; }
        public System.DateTime datumPutovanja { get; set; }
        public string brojSjedista { get; set; }
        public bool Aktivna { get; set; }
        public int TipKarteId { get; set; }
        public int PosjecujeLokacijeId { get; set; }
    }
}
