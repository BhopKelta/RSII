using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Cities_Passing_Line_Model
    {
        public string Grad { get; set; }
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string vrijemePolaska { get; set; }
        public float cijenaOdPolaska { get; set; }
        public Nullable<System.TimeSpan> Vrijeme_dolaska { get; set; }
        public string Tip_karte { get; set; }
        public double Cijena_od_grada_destinacije { get; set; }
    }
}
