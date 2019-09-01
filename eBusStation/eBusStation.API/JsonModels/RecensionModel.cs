using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBusStation.API.JsonModels
{
    public class RecensionModel
    {
        public int Id { get; set; }
        public double Ocjena { get; set; }
        public string Opis { get; set; }
        public string Komentar { get; set; }
        public Nullable<int> KlijentiId { get; set; }
        public Nullable<int> KartaId { get; set; }
    }
}