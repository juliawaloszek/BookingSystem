using System;
using System.Collections.Generic;
using System.Text;
using BookingSystem.Infrastructure.Data;

namespace IntegrationTests.Repositories.AppointmentRepositoryTests
{
    public class GetById
    {
        private readonly BookingSystemContext _context;
        private readonly AppointmentRepository _appointmentRepository;
        // private OrderBuilder OrderBuilder { get; } = new OrderBuilder();

        public GetById(BookingSystemContext context)
        {
            _context = context;
        }

    }
}
