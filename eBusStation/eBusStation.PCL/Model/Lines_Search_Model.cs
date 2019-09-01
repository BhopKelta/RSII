using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
   public class Lines_Search_Model
    {
        public int Id { get; set; }
        public float cijenaOdPolaska { get; set; }
        public string vrijemeDolaska { get; set; }
        public string vrijemePolaska { get; set; }
        public string PosjeceniGrad { get; set; }
        public Nullable<double> CijenaOdTrenutnogGradaDoDestinacije { get; set; }
        public Nullable<bool> isStudentska { get; set; }
        public string Naziv { get; set; }
        public string TipLinije { get; set; }
        public string Prevoznik { get; set; }
    }
}
