using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Employee : BaseEntity {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }






















        // [StringLength(60, MinimumLength = 3)]
        // [Display(Name ="Imie pracownika" )]
        // public string FirstName { get; set; }


        // [StringLength(60, MinimumLength = 3)]
        // [Display(Name ="Nazwisko pracownika" )]
        // public string LastName { get; set; }

        // public int SalonId { get; set; }
        // public Salon Salon { get; set; }

        // [Required(ErrorMessage = "Pole numer telefonu jest wymagane")]
        // [Display(Name ="Numer telefonu" )]
        // [Phone]
        // public string PhoneNumber { get; set; }

        // public virtual ICollection<Appointment> Appointments { get; set; }
        
    }
}