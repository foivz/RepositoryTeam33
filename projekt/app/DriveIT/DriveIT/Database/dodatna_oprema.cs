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
    
    public partial class dodatna_oprema
    {
        public dodatna_oprema()
        {
            this.vozilo = new HashSet<vozilo>();
        }
    
        public int id_dodatna_oprema { get; set; }
        public int dobavljac_iddobavljac { get; set; }
        public string naziv { get; set; }
        public int model { get; set; }
        public int boja { get; set; }
        public int kolicina { get; set; }
        public int cijena { get; set; }
        public int raspoloživo { get; set; }
    
        public virtual dobavljac dobavljac { get; set; }
        public virtual ICollection<vozilo> vozilo { get; set; }
    }
}