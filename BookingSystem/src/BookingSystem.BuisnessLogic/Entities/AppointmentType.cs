using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class AppointmentType :BaseEntity
    {

        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Nazwa usługi" )]
        public string Name { get; set; }


        [Display(Name ="Czas trwania usługi" )]
        // public Duration Duration { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}