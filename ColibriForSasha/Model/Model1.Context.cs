﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColibriForSasha.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SevodinKursovayaEntities : DbContext
    {
        public SevodinKursovayaEntities()
            : base("name=SevodinKursovayaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<StatusOrder> StatusOrder { get; set; }
        public virtual DbSet<StatusProduct> StatusProduct { get; set; }
        public virtual DbSet<TypeOfProduct> TypeOfProduct { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
