using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Recension_Model
    {
        public int Id { get; set; }
        public double Ocjena { get; set; }
        public string Opis { get; set; }
        public string Komentar { get; set; }
        public Nullable<int> KlijentiId { get; set; }
        public Nullable<int> KartaId { get; set; }
    }
}
