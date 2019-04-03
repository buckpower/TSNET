﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            modelBuilder.Entity<Comanda>()
                .HasOptional(f => f.DetaliuComanda)
                .WithRequired(s => s.Comanda);

            modelBuilder.Entity<Auto>()
                .HasRequired<Client>(a => a.Client);
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Sasiu> Sasius { get; set; }
        public virtual DbSet<Mecanic> Mecanics { get; set; }
        public virtual DbSet<Auto> Autoes { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Imagine> Imagines { get; set; }
        public virtual DbSet<Operatie> Operaties { get; set; }
        public virtual DbSet<Comanda> Comandas { get; set; }
        public virtual DbSet<DetaliuComanda> DetaliuComandas { get; set; }
    }
}
