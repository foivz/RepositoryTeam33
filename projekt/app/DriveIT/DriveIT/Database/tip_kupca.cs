//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DriveIT.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tip_kupca
    {
        public tip_kupca()
        {
            this.kupac = new HashSet<kupac>();
        }
    
        public int id_tip_kupca { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<kupac> kupac { get; set; }
    }
}
