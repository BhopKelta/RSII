using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Lines_With_Traveler_Model
    {
        public string Naziv_linije { get; set; }
        public string Tip_linije { get; set; }
        public string Prevoznik { get; set; }
        public string Vrijeme_polaska { get; set; }
        public int Id { get; set; }
    }
}
