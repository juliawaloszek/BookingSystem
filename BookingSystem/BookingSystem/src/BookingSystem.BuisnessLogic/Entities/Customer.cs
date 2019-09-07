using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Customer : BaseEntity
    {
        /// <summary>
        /// Imie klienta
        /// </summary>
        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Imie klienta" )]
        public string FirstName { get; set; }

        /// <summary>
        /// Nazwisko klienta
        /// </summary>
        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Nazwisko klienta" )]
        public string LastName { get; set; }


        /// <summary>
        /// Numer telefonu
        /// </summary>
        [Required(ErrorMessage = "Pole numer telefonu jest wymagane")]
        [Display(Name ="Numer telefonu" )]
        [Phone]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        [Required(ErrorMessage = "Pole e-mail jest wymagane")]
        [Display(Name ="E-mail" )]
        [EmailAddress]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Lista wizyt
        /// </summary>
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}