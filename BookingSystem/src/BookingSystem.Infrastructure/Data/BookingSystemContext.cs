using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BookingSystem.BuisnessLogic.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BookingSystem.BuisnessLogic.Entities.Enums;

namespace BookingSystem.Infrastructure.Data
{
    public class BookingSystemContext : DbContext
    {
        public BookingSystemContext(DbContextOptions<BookingSystemContext> options) : base(options) { }

        public BookingSystemContext()
        {

        }

        #region Salons
        public DbSet<Salon> Salons { get; set; }
        public DbSet<WorkingHour> WorkingHours { get; set; }     
        #endregion

        #region Appointments
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        #endregion

        #region Customers
        public DbSet<Customer> Customers { get; set; }
        #endregion

        #region Employees
        public DbSet<Employee> Employees { get; set; }
        #endregion



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BuisnessLogic.db");
        }


        protected override void OnModelCreating (ModelBuilder builder)
        {

            builder.Entity<Appointment>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Appointment>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Appointment>()
                .HasOne(x => x.AppointmentType);

            builder.Entity<Appointment>()
                .Property(x => x.AppointmentStatus)
                   .HasConversion(new EnumToNumberConverter<AppointmentStatus, int>());
        }


    }
}
