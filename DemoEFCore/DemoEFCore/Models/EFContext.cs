using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DemoEFCore.Models
{
    class EFContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DemoEFCoreDB; Trusted_Connection=True";
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        //public DbSet<DbTypeTest> DbTypeTests { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAddress>()
                .HasKey(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                        .HasOne<EmployeeAddress>(p => p.EmployeeAddress)
                        .WithOne(s => s.Employee)
                        .HasForeignKey<EmployeeAddress>(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasOne<Department>(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<EmployeesInProject>()
                .HasOne<Employee>(e => e.Employee)
                .WithMany(p => p.EmployeesinProject);

            modelBuilder.Entity<EmployeesInProject>()
                .HasOne<Project>(e => e.Project)
                .WithMany(p => p.EmployeesinProject);

            modelBuilder.Entity<EmployeesInProject>()
                .HasKey(e => new { e.EmployeeId, e.ProjectId });
        }



    }
}
