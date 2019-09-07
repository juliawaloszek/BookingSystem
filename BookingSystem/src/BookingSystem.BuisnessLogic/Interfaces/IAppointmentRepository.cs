using System.Collections.Generic;
using BookingSystem.BuisnessLogic.Entities;

namespace BookingSystem.BuisnessLogic.Interfaces
{
    public interface IAppointmentRepository : IBaseRepository<Appointment>
    {
        List<Appointment> GetAppointmentsByEmployeeId(int employeeId);
        List<Appointment> GetAppointmentsByCustomerId(int customerId);     
    }
}