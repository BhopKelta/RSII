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
    
    public partial class Kartice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kartice()
        {
            this.Transakcije = new HashSet<Transakcije>();
        }
    
        public int Id { get; set; }
        public string BrojKartice { get; set; }
        public System.DateTime datumIsteka { get; set; }
        public string Banka { get; set; }
        public string vrstaKartice { get; set; }
        public float StanjeRacuna { get; set; }
        public int SredstvoPlacanjaId { get; set; }
        public int KlijentiId { get; set; }
    
        public virtual SredstvoPlacanja SredstvoPlacanja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transakcije> Transakcije { get; set; }
        public virtual Korisnici Korisnici { get; set; }
    }
}
