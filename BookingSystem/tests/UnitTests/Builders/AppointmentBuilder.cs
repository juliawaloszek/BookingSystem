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
        public DateTime TestStartTime => new DateTime(0, 0, 0, 8, 30, 5);
        public DateTime TestEndTime => new DateTime(0, 0, 0, 9, 30, 5);
        public AppointmentStatus TestAppointmentStatus => AppointmentStatus.Came;
        public AppointmentType TestAppointmentType => new AppointmentType
        {
            Id = 1,
            Name = "TestName",
            Duration=60
        };
        public int TestCustomerId => 1;
        public Customer Customer => new Customer
        {
            Id = 1,
            FirstName = "Ania",
            LastName = "Kaminska",
            PhoneNumber = "500000000",
            EmailAddress = "aniakaminska@wp.pl",
        };

    }
}
