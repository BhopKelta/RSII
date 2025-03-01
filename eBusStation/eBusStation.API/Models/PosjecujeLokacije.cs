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
    
    public partial class PosjecujeLokacije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PosjecujeLokacije()
        {
            this.Karte = new HashSet<Karte>();
        }
    
        public int Id { get; set; }
        public float cijenaOdPolaska { get; set; }
        public int LinijeId { get; set; }
        public int GradId { get; set; }
        public string vrijemeDolaska { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<double> CijenaOdTrenutnogGradaDoDestinacije { get; set; }
        public Nullable<bool> isStudentska { get; set; }
    
        public virtual Gradovi Gradovi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karte> Karte { get; set; }
        public virtual Linije Linije { get; set; }
    }
}
