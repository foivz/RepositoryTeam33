﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class T33_DBEntities : DbContext
    {
        public T33_DBEntities()
            : base("name=T33_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cijena> cijena { get; set; }
        public virtual DbSet<dobavljac> dobavljac { get; set; }
        public virtual DbSet<dodatna_oprema> dodatna_oprema { get; set; }
        public virtual DbSet<korisnik> korisnik { get; set; }
        public virtual DbSet<kupac> kupac { get; set; }
        public virtual DbSet<marka_vozila> marka_vozila { get; set; }
        public virtual DbSet<model_vozila> model_vozila { get; set; }
        public virtual DbSet<nalog_za_servis> nalog_za_servis { get; set; }
        public virtual DbSet<parking> parking { get; set; }
        public virtual DbSet<slika_vozilo> slika_vozilo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tip_korisnika> tip_korisnika { get; set; }
        public virtual DbSet<tip_kupca> tip_kupca { get; set; }
        public virtual DbSet<tip_poreza> tip_poreza { get; set; }
        public virtual DbSet<tip_vozila> tip_vozila { get; set; }
        public virtual DbSet<ugovor> ugovor { get; set; }
        public virtual DbSet<vozilo> vozilo { get; set; }
        public virtual DbSet<zapisnik> zapisnik { get; set; }
    }
}