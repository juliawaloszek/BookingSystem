using System;
using System.Collections.Generic;
using System.Text;
using BookingSystem.Infrastructure.Data;

namespace IntegrationTests.Repositories.AppointmentRepositoryTests
{
    public class GetById
    {
        private readonly BookingSystemContext _context;

        public GetById(BookingSystemContext context)
        {
            _context = context;
        }

    }
}
