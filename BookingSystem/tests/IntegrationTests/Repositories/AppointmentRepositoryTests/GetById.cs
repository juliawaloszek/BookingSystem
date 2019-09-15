using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using UnitTests.Builders;
using Xunit;
using Xunit.Abstractions;

namespace IntegrationTests.Repositories.AppointmentRepositoryTests
{
    public class GetById
    {
        private readonly BookingSystemContext _context;
        private readonly AppointmentRepository _appointmentRepository;
        private AppointmentBuilder AppointmentBuilder { get; } = new AppointmentBuilder();

        private readonly ITestOutputHelper _output;
        public GetById(ITestOutputHelper output)
        {
            _output = output;
            var dbOptions = new DbContextOptionsBuilder<BookingSystemContext>()
                .UseInMemoryDatabase(databaseName: "TestCatalog")
                .Options;
            _context = new BookingSystemContext(dbOptions);
            _appointmentRepository = new AppointmentRepository(_context);
        }

        [Fact]
        public async Task GetsExistingAppointment()
        {
            var existingAppointment = AppointmentBuilder.WithDefaultValues();
            _context.Appointments.Add(existingAppointment);
            _context.SaveChanges();
            int appointmentId = existingAppointment.Id;
            _output.WriteLine($"AppointmentId: {appointmentId}");

            var appointmentFromRepo = await _appointmentRepository.GetByIdAsync(appointmentId);
            Assert.Equal(AppointmentBuilder.TestCustomer.Id, appointmentFromRepo.CustomerId);
            Assert.Equal(AppointmentBuilder.TestEmployee.Id, appointmentFromRepo.EmployeeId);

        }

    }
}
