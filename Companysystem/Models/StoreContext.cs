﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Models
{
    public class StoreContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CompanyV7;Trusted_Connection=True;encrypt= false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Item> items { get; set; }
        public DbSet<CostsAndExpensesModel> CostsAndExpensesModels { get; set; }

        public DbSet<Client> clients { get; set; }
        public DbSet<Sales> Salesd { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Purchases> Purchases { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<StoreTransaction> StoresTransaction { get; set; }

    }
}
