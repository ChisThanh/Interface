﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interface.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HighlandEntities : DbContext
    {
        public HighlandEntities()
            : base("name=HighlandEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<OrderPD> OrderPDs { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ProcessedFood> ProcessedFoods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductTransferDetail> ProductTransferDetails { get; set; }
        public virtual DbSet<ProductTransfer> ProductTransfers { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TableSalary> TableSalaries { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
