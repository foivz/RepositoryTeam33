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
    
    public partial class tip_poreza
    {
        public tip_poreza()
        {
            this.cijena = new HashSet<cijena>();
            this.cijena1 = new HashSet<cijena>();
        }
    
        public int id_tip_poreza { get; set; }
        public int postotak { get; set; }
    
        public virtual ICollection<cijena> cijena { get; set; }
        public virtual ICollection<cijena> cijena1 { get; set; }
    }
}
