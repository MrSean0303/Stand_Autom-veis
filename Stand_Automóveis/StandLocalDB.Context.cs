﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stand_Automoveis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StandLocalDBContainer : DbContext
    {
        public StandLocalDBContainer()
            : base("name=StandLocalDBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Carros> Carro { get; set; }
        public virtual DbSet<Parcelas> Parcela { get; set; }
        public virtual DbSet<Servicos> Servico { get; set; }
        public virtual DbSet<Vendas> Vendas { get; set; }
        public virtual DbSet<Alugueres> Aluguer { get; set; }
    }
}
