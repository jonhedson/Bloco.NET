using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFFluentApi.Models
{
    public class EFFluentContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFFluentDB; Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //Entity Configuration
            modelbuilder.Entity<Country>().HasKey(s => s.CountryId);

            // Property Configurations
            modelbuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasColumnName("CountryName")
                    .HasDefaultValue("USA")
                    .IsRequired();

                entity.Property(e => e.AddedOne)
                    .HasColumnType("date")
                    .HasDefaultValueSql("getdate()");
            });

            modelbuilder.Entity<City>()
                .HasOne(e => e.Country)
                .WithMany(e => e.City)
                .HasForeignKey(e => e.FKCountry)
                .OnDelete(DeleteBehavior.Cascade);

            //  One to One
            modelbuilder.Entity<City>()
                .HasOne(e => e.CityInformation)
                .WithOne(e => e.City)
                .HasForeignKey<City>(e => e.CityInformationId);

            // Many to Many
            modelbuilder.Entity<TeacherStudent>().HasKey(t => new { t.StudentId, t.TeacherId });

            modelbuilder.Entity<TeacherStudent>()
                .HasOne(t => t.Student)
                .WithMany(t => t.TeacherStudent)
                .HasForeignKey(t => t.StudentId);

            modelbuilder.Entity<TeacherStudent>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.TeacherStudent)
                .HasForeignKey(t => t.TeacherId);







        }
    }

    
}
