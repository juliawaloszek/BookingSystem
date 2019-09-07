using System.Collections.Generic;
using System.Linq;
using BookingSystem.BuisnessLogic.Entities;
using BookingSystem.BuisnessLogic.Interfaces;
using BookingSystem.Infrastructure.Repositories;

namespace BookingSystem.Infrastructure.Data
{
    public class AppointmentRepository : BaseRepository<Appointment>
    {
        public AppointmentRepository(BookingSystemContext context) : base(context)
        {
        }


        // public List<Appointment> GetAppointmentsByEmployeeId(int employeeId)
        // {
        //     var appointmentList = FindBy(x => x.Employee.Id == employeeId)
        //         .Select(x=> new Appointment { 
        //             Customer = x.Customer, 
        //             Date= x.Date, 
        //             StartTime= x.StartTime, 
        //             EndTime= x.EndTime, 
        //             Id=x.Id 
        //             }).ToList();
        //     return appointmentList;
        // }

    
        public List<Appointment> GetAppointmentsByCustomerId(int customerId)
        {
            throw new System.NotImplementedException();
        }


    }
}