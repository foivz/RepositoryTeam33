﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class T33_DBEntities2 : DbContext
    {
        public T33_DBEntities2()
            : base("name=T33_DBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cijena> cijena { get; set; }
        public DbSet<dobavljac> dobavljac { get; set; }
        public DbSet<dodatna_oprema> dodatna_oprema { get; set; }
        public DbSet<korisnik> korisnik { get; set; }
        public DbSet<kupac> kupac { get; set; }
        public DbSet<marka_vozila> marka_vozila { get; set; }
        public DbSet<model_vozila> model_vozila { get; set; }
        public DbSet<nalog_za_servis> nalog_za_servis { get; set; }
        public DbSet<parking> parking { get; set; }
        public DbSet<slika_vozilo> slika_vozilo { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<tip_korisnika> tip_korisnika { get; set; }
        public DbSet<tip_kupca> tip_kupca { get; set; }
        public DbSet<tip_poreza> tip_poreza { get; set; }
        public DbSet<tip_vozila> tip_vozila { get; set; }
        public DbSet<ugovor> ugovor { get; set; }
        public DbSet<vozilo> vozilo { get; set; }
        public DbSet<zapisnik> zapisnik { get; set; }
    }
}
