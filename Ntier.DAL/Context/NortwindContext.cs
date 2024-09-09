using Microsoft.EntityFrameworkCore;
using Ntier.DAL.Configs;
using Ntier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Context
{
    public class NortwindContext : DbContext
    {

        const string connectionString = "server=MURATHAN\\SQLEXPRESS01;database=NorthwindNTİER;Trusted_Connection=True;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new CustomerDemoConfig());
            modelBuilder.ApplyConfiguration(new EmployeesConfig());
            modelBuilder.ApplyConfiguration(new OrdersConfig());
            modelBuilder.ApplyConfiguration(new ProductsConfig());
            modelBuilder.ApplyConfiguration(new RegionConfig());
            modelBuilder.ApplyConfiguration(new ShippersConfig());
            modelBuilder.ApplyConfiguration(new SuppliersConfig());
            modelBuilder.ApplyConfiguration(new TerritoriesConfig());
            modelBuilder.ApplyConfiguration(new OrderDetailConfig());


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerCustomerDemo> customerCustomerDemos { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Employee> Employees
        { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }




    }
}
