//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DriveIT.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class dobavljac
    {
        public dobavljac()
        {
            this.dodatna_oprema = new HashSet<dodatna_oprema>();
            this.ugovor = new HashSet<ugovor>();
        }
    
        public int id_dobavljac { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string tvrtka { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string faks { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<dodatna_oprema> dodatna_oprema { get; set; }
        public virtual ICollection<ugovor> ugovor { get; set; }
    }
}
