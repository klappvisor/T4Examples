﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T4Examples.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AspearinEntities : DbContext
    {
        public AspearinEntities()
            : base("name=AspearinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<AttestationPeriods> AttestationPeriods { get; set; }
        public DbSet<FridayConfigs> FridayConfigs { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<MonthPoints> MonthPoints { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Polls> Polls { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<TokenItems> TokenItems { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Variants> Variants { get; set; }
    }
}
