﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NyamDesktop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBNaymNyamEntities : DbContext
    {
        public DBNaymNyamEntities()
            : base("name=DBNaymNyamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Empleye> Empleyes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<OrderDish> OrderDishes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<ProcessIngredient> ProcessIngredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
    }
}
