using BookingSystem.BuisnessLogic.Entities;
using BookingSystem.BuisnessLogic.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Builders
{
    public class AppointmentBuilder
    {
        private Appointment _appointment;
        public DateTime TestDate => DateTime.Today;
        public DateTime TestStartTime => new DateTime(2019, 1, 1, 8, 30, 5);
        public DateTime TestEndTime => new DateTime(2019, 1, 1, 9, 30, 5);
        public AppointmentStatus TestAppointmentStatus => AppointmentStatus.Came;
        public AppointmentType TestAppointmentType => new AppointmentType
        {
            Id = 1,
            Name = "TestName",
            Duration=60
        };
        // public int TestCustomerId => 1;
        public Customer TestCustomer => new Customer
        {
            Id = 1,
            FirstName = "Ania",
            LastName = "Klientka",
            PhoneNumber = "500000000",
            EmailAddress = "aniakaminska@wp.pl",
        };

        public Employee TestEmployee => new Employee
        {
            Id = 1,
            FirstName = "Basia ",
            LastName = "Fryzjerka",
            PhoneNumber = "500000000"
        };

        public AppointmentBuilder()
        {
            _appointment = WithDefaultValues();
        }

        public Appointment Build()
        {
            return _appointment;
        }

        public Appointment WithDefaultValues()
        {
            var appointment = new Appointment
            {
                Date = TestDate,
                StartTime = TestStartTime,
                EndTime = TestEndTime,
                Description = "Test description",
                AppointmentStatus = TestAppointmentStatus, 
                AppointmentType = TestAppointmentType,
                CustomerId = TestCustomer.Id,
                Customer = TestCustomer,
                EmployeeId = TestEmployee.Id,
                Employee = TestEmployee
            };
            return appointment;
        }

    }
}
