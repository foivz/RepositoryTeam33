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
        public string model { get; set; }
        public string boja { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<int> cijena { get; set; }
        public Nullable<bool> raspoloživo { get; set; }
    
        public virtual dobavljac dobavljac { get; set; }
        public virtual ICollection<vozilo> vozilo { get; set; }
    }
}
