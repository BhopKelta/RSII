using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class OfferInfo_Model
    {
        public float cijenaOdPolaska { get; set; }
        public Nullable<double> CijenaOdTrenutnogGradaDoDestinacije { get; set; }
        public Nullable<bool> isStudentska { get; set; }
        public string Linija { get; set; }
        public string Grad { get; set; }
    }
}
