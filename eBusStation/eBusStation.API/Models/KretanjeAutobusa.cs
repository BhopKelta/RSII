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
    using System.Collections.Generic;
    
    public partial class KretanjeAutobusa
    {
        public int Id { get; set; }
        public float TrajanjePuta { get; set; }
        public int LinijeId { get; set; }
        public int AutobusId { get; set; }
        public System.DateTime vrijemePolaska { get; set; }
    
        public virtual Autobusi Autobusi { get; set; }
        public virtual Linije Linije { get; set; }
    }
}
