using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusStation.PCL.Model
{
    public class Korisnici
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime datumRodjenja { get; set; }
        public string Spol { get; set; }
        public string Telefon { get; set; }
        public string ZemljaPorijekla { get; set; }
        public string Discriminator { get; set; }
        public string BrojIndeksa { get; set; }
        public byte[] slikaIndeksa { get; set; }
        public byte[] slikaPenzionerskeKartice { get; set; }
        public Nullable<int> GodineIskustva { get; set; }
        public string Email { get; set; }
        public bool isValid { get; set; }
        public string Zanimanje { get; set; }
        public int UlogeId { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}
