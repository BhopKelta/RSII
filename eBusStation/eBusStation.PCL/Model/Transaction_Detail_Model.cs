using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Transaction_Detail_Model
    {
        public int Id { get; set; }
        public int Kolicina { get; set; }
        public float UkupnaCijena { get; set; }
        public int TransakcijaId { get; set; }
        public int KartaId { get; set; }
        public Nullable<int> PopustId { get; set; }
    }
}
