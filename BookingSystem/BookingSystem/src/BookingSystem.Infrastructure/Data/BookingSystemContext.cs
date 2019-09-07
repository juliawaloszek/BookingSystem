using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BookingSystem.BuisnessLogic.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingSystem.Infrastructure.Data
{
    public class BookingSystemContext : DbContext
    {
        public BookingSystemContext(DbContextOptions<BookingSystemContext> options) : base(options) { }

        public BookingSystemContext()
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BuisnessLogic.db");
        }


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {

            var customer = modelBuilder.Entity<Customer>();
            // customer.HasMany(x => x.Appointments).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);

           // customer.HasKey(x=>x.Id);

           // customer.ToTable("KLIENCI");

        }

    }
}
