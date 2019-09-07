using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Salon : BaseEntity
    {
        /// <summary>
        /// Nazwa zwyczajowa salonu
        /// np idealnie
        /// </summary>
        [Required(ErrorMessage = "Pole nazwa jest wymagane")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Nazwa salonu" )]
        public string Name { get; set; }

        /// <summary>
        /// Formalna nazwa salonu
        /// np idealnie sp zoo
        /// </summary>
        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Pełna nazwa salonu" )]
        public string FullName { get; set; }

        /// <summary>
        /// Ulica
        /// </summary>
        [Required(ErrorMessage = "Pole ulica jest wymagane")]
        [Display(Name ="Ulica" )]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Numer budynku
        /// </summary>
        [Required(ErrorMessage = "Pole numer budynku jest wymagane")]
        [Display(Name ="Numer Budynku" )]
        public int AddressBuildingNumber { get; set; }

        /// <summary>
        /// Numer mieszkania
        /// </summary>
        [Display(Name ="Numer mieszkania" )]
        public int AddressApartmentNumber { get; set; }

        /// <summary>
        /// Numer telefonu
        /// </summary>
        [Required(ErrorMessage = "Pole numer telefonu jest wymagane")]
        [Display(Name ="Numer telefonu" )]
        [Phone]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Godziny otwarcia salonu Dzień tygodnia, od, do 
        /// </summary>
        public virtual ICollection<WorkingHour> WorkingHours { get; set; }


        /// <summary>
        /// Lista pracowników
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }








        
    }
}