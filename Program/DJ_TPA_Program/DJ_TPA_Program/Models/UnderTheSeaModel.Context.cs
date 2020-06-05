﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DJ_TPA_Program.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnderTheSeaDatabaseEntities : DbContext
    {
        public UnderTheSeaDatabaseEntities()
            : base("name=UnderTheSeaDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<RideType> RideTypes { get; set; }
        public virtual DbSet<RideSafety> RideSafeties { get; set; }
        public virtual DbSet<DetailCreation> DetailCreations { get; set; }
        public virtual DbSet<HeaderCreation> HeaderCreations { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<HeaderResponse> HeaderResponses { get; set; }
        public virtual DbSet<HeaderConstruction> HeaderConstructions { get; set; }
        public virtual DbSet<HeaderMaintenance> HeaderMaintenances { get; set; }
        public virtual DbSet<ItemPiece> ItemPieces { get; set; }
        public virtual DbSet<HeaderFundRequest> HeaderFundRequests { get; set; }
        public virtual DbSet<HeaderPurchaseRequest> HeaderPurchaseRequests { get; set; }
        public virtual DbSet<Firing> Firings { get; set; }
        public virtual DbSet<RequestRaiseSalary> RequestRaiseSalaries { get; set; }
        public virtual DbSet<LeavingPermission> LeavingPermissions { get; set; }
        public virtual DbSet<ResignRequest> ResignRequests { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderRequest> OrderRequests { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Attraction> Attractions { get; set; }
        public virtual DbSet<HeaderAttraction> HeaderAttractions { get; set; }
        public virtual DbSet<HeaderIngredient> HeaderIngredients { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
    }
}
