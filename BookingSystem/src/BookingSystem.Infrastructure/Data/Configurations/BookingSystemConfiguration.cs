using System;
using System.Collections.Generic;
using BookingSystem.BuisnessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NodaTime;

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
                    Name = "Salon BEA",
                    FullName = "Salon Fryzjerski BEA Beata Bunar",
                    AddressCity = "Gliwice",
                    AddressStreet = "Zygmunta Starego ",
                    AddressBuildingNumber = 1,
                    AddressApartmentNumber = 2,
                    PhoneNumber = "32 238 21 93",
                    WorkingHours = new List<WorkingHour> {
                        new WorkingHour { DayOfWeek = DayOfWeek.Monday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Tuesday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Wednesday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Thursday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Friday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Saturday, OpenHour = "8:00", CloseHour = "13:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Sunday, OpenHour = "0", CloseHour = "0"}
                    }
                },
                new Salon {
                    Name = "Art Fryzjer",
                    FullName = "ART FRYZJER SP Z O O",
                    AddressCity = "Warszawa",
                    AddressStreet = "Warszawa",
                    AddressBuildingNumber = 15,
                    AddressApartmentNumber = 23,
                    PhoneNumber = "500500500",
                    WorkingHours = new List<WorkingHour> {
                        new WorkingHour { DayOfWeek = DayOfWeek.Monday, OpenHour = "10:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Tuesday, OpenHour = "10:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Wednesday, OpenHour = "10:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Thursday, OpenHour = "10:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Friday, OpenHour = "10:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Saturday, OpenHour = "12:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Sunday, OpenHour = "12:00", CloseHour = "18:00"}
                    }
                },
                new Salon {
                    Name = "Salon Fryzjerski",
                    FullName = "Salon Fryzjerski Dla Pań i Panów Bożena Drewek",
                    AddressCity = "Kartuzy",
                    AddressStreet = "3 maja",
                    AddressBuildingNumber = 3,
                    PhoneNumber = "589101189",
                    WorkingHours = new List<WorkingHour> {
                        new WorkingHour { DayOfWeek = DayOfWeek.Monday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Tuesday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Wednesday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Thursday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Friday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Saturday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Sunday, OpenHour = "0", CloseHour = "0"}
                    }
                },
                new Salon {
                    Name = "Twój fryzjer",
                    FullName = "TWÓJ FRYZJER SP Z O O",
                    AddressCity = "Katowice",
                    AddressStreet = "Gliwicka",
                    AddressBuildingNumber = 155,
                    PhoneNumber = "364918344",
                    WorkingHours = new List<WorkingHour> {
                        new WorkingHour { DayOfWeek = DayOfWeek.Monday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Tuesday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Wednesday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Thursday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Friday, OpenHour = "8:00", CloseHour = "18:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Saturday, OpenHour = "8:00", CloseHour = "13:00"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Sunday, OpenHour = "0", CloseHour = "0"}
                    }
                },
                new Salon {
                    Name = "Super fryzjer",
                    AddressCity = "Opole",
                    AddressStreet = "Komandosow",
                    AddressBuildingNumber = 12,
                    AddressApartmentNumber = 22,
                    PhoneNumber = "500000000",
                    WorkingHours = new List<WorkingHour> {
                        new WorkingHour { DayOfWeek = DayOfWeek.Monday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Tuesday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Wednesday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Thursday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Friday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Saturday, OpenHour = "0", CloseHour = "0"},
                        new WorkingHour { DayOfWeek = DayOfWeek.Sunday, OpenHour = "0", CloseHour = "0"}
                    }
                }                                                                
            );
        }
    }

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasData
            (
                new Employee {
                    FirstName = "",
                    LastName = "",
                    PhoneNumber = "",
                    // SalonId = _context.Salons.FirstOrDefaultAsync(s =>s.Name == "Salon BEA").Id,
                    // Salon =  _context.Salons.FirstOrDefaultAsync(s =>s.Name == "Salon BEA").Result
                }
            );
        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasData
            (
                new Customer {}
            );
        }
    }
}