﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace autofin.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class examen_Jose_Antonio_Estrada_ReyesEntities : DbContext
    {
        public examen_Jose_Antonio_Estrada_ReyesEntities()
            : base("name=examen_Jose_Antonio_Estrada_ReyesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<t_clientes> t_clientes { get; set; }
        public DbSet<t_detalleFactura> t_detalleFactura { get; set; }
        public DbSet<t_facturas> t_facturas { get; set; }
        public DbSet<t_productos> t_productos { get; set; }
    }
}