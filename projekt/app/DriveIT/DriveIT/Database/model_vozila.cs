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
    
    public partial class model_vozila
    {
        public model_vozila()
        {
            this.vozilo = new HashSet<vozilo>();
        }
    
        public int id_model_vozila { get; set; }
        public string naziv { get; set; }
        public int marka_vozila { get; set; }
    
        public virtual marka_vozila marka_vozila1 { get; set; }
        public virtual ICollection<vozilo> vozilo { get; set; }
    }
}
