using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Customer : BaseEntity
    {

        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Imie klienta" )]
        public string FirstName { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Nazwisko klienta" )]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Pole numer telefonu jest wymagane")]
        [Display(Name ="Numer telefonu" )]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Pole e-mail jest wymagane")]
        [Display(Name ="E-mail" )]
        [EmailAddress]
        public string EmailAddress { get; set; }


        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}