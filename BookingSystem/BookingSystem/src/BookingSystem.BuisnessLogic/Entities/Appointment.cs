using System;
using System.ComponentModel.DataAnnotations;
using BookingSystem.BuisnessLogic.Validations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Appointment : BaseEntity
    {
        /// <summary>
        /// Data wizyty
        /// </summary>
        [Required]
        [Display(Name = "Data wizyty")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [AppointmentDateValidation(ErrorMessage = "Wybierz prawidłową datę (z przyszłości)")]
        public DateTime Date { get; set; } 


        [Required]
        [Display(Name = "Początek wizyty")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
    }
}