﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcEntretenimientoWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ent_familiarEntities : DbContext
    {
        public ent_familiarEntities()
            : base("name=ent_familiarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<catalogo> catalogo { get; set; }
        public DbSet<club> club { get; set; }
        public DbSet<detalle_dia_campo> detalle_dia_campo { get; set; }
        public DbSet<detalleoferta> detalleoferta { get; set; }
        public DbSet<juego> juego { get; set; }
        public DbSet<master_catalogo> master_catalogo { get; set; }
        public DbSet<material> material { get; set; }
        public DbSet<oferta> oferta { get; set; }
        public DbSet<responsable_familia> responsable_familia { get; set; }
        public DbSet<servicio> servicio { get; set; }
        public DbSet<solicitud_dia_campo> solicitud_dia_campo { get; set; }
        public DbSet<usuario> usuario { get; set; }
    }
}
