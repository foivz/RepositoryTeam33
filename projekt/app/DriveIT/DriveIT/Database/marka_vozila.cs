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
    
    public partial class marka_vozila
    {
        public marka_vozila()
        {
            this.model_vozila = new HashSet<model_vozila>();
        }
    
        public int id_marka_vozila { get; set; }
        public string naziv { get; set; }
        public string drzava { get; set; }
    
        public virtual ICollection<model_vozila> model_vozila { get; set; }
    }
}
