using System;
using System.Collections.Generic;
using System.Text;
using BookingSystem.BuisnessLogic.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // public DbSet<Appointment> Appointments { get; set; }
    }
}
