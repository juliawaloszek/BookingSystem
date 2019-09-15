using BookingSystem.BuisnessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookingSystem.Infrastructure.Data.Specifiactions
{
    public class CustomerAppointments : BaseSpecification<Appointment>
    {
        public CustomerAppointments(int customerId) : base(x=>x.CustomerId == customerId)
        {
            AddInclude(x => x.Customer);
            AddInclude(x => x.Employee);
            AddInclude(x => x.AppointmentType);

           
        }
    }
}
