using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class AutoBus_On_Line_Model
    {
        public int brojSjedistaBusa { get; set; }
        public byte[] slikaAutobusa { get; set; }
        public string Proizvodjac { get; set; }
        public int ZauzetoMjestaUkupno { get; set; }
    }
}
