﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using CapaEntidades;
    
    public partial class ProyectoFinalP2Entities : DbContext
    {
        public ProyectoFinalP2Entities()
            : base("name=ProyectoFinalP2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<EnvioDocumento> EnvioDocumento { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
