using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystem.BuisnessLogic.Entities;

namespace BookingSystem.Infrastructure.Data
{
    public class BookingSystemContextSeed
    {
        public static async Task SeedAsync(BookingSystemContext context, int? retry = 0)
        {
            int retryForAvailability = retry.Value;

            if (!context.Salons.Any())
            {
                context.Salons.AddRange(
                    GetPreconfiguredSalons());

                await context.SaveChangesAsync();
            }


        }

        static IEnumerable<Salon> GetPreconfiguredSalons()
        {
        //     List<WorkingHour> workingHourExample = new List<WorkingHour> { new WorkingHour { DayOfWeek = DayOfWeek.Monday, StartHour = new DateTime(2010,1,1,8,0,0), EndHour = new DateTime(2010,1,1,8,0,0) }, new Car { Name = "Golf", Color = Color.Blue} };



        //     return new List<Salon>()
        //     {
        //         new Salon() { Name = "Salon Bea", FullName = "SalonBea sp z.o.o", AddressStreet="Zygmunta Starego", AddressBuildingNumber = 22, PhoneNumber="543343934", 
        //         WorkingHours = new List<WorkingHour>{}

        //         WorkingHours = new WorkingHour{ DayOfWeek = DayOfWeek.Monday}
                    
        //             Brand = "Azure"},
        //     };
        return null;
        }
        
    }
}

