//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eBusStation.API.Models
{
    using System;
    
    public partial class usp_mobile_Search_Lines_Result
    {
        public int Id { get; set; }
        public float cijenaOdPolaska { get; set; }
        public string vrijemeDolaska { get; set; }
        public Nullable<double> CijenaOdTrenutnogGradaDoDestinacije { get; set; }
        public Nullable<bool> isStudentska { get; set; }
        public string Naziv { get; set; }
        public string TipLinije { get; set; }
        public string Prevoznik { get; set; }
        public string vrijemePolaska { get; set; }
        public int LinijaId { get; set; }
        public string PosjeceniGrad { get; set; }
    }
}
