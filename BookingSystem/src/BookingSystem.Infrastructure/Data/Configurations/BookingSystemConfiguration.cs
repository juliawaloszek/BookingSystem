using System.Collections.Generic;
using BookingSystem.BuisnessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Infrastructure.Data.Configurations
{
    public class SalonConfiguration : IEntityTypeConfiguration<Salon>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Salon> builder)
        {
        
            builder.ToTable("Salon");

            builder.HasData
            (
                new Salon {
                    Name = "",
                    FullName = "",
                    AddressStreet = "",
                    AddressBuildingNumber = 1,
                    AddressApartmentNumber = 2,
                    PhoneNumber = "",
                    WorkingHours = new List<WorkingHour> {
                       
                    }
                }
            );

                // builder.ToTable("Student");
                // builder.Property(s => s.Age)
                //     .IsRequired(false);
                // builder.Property(s => s.IsRegularStudent)
                //     .HasDefaultValue(true);
            
                // builder.HasData
                // (
                //     new Student
                //     {
                //         Id = Guid.NewGuid(),
                //         Name = "John Doe",
                //         Age = 30
                //     },
                //     new Student
                //     {
                //         Id = Guid.NewGuid(),
                //         Name = "Jane Doe",
                //         Age = 25
                //     },
                //     new Student
                //     {
                //         Id = Guid.NewGuid(),
                //         Name = "Mike Miles",
                //         Age = 28
                //     }
                // );
        }
    }
}