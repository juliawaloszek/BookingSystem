using System;
using System.ComponentModel.DataAnnotations;
using BookingSystem.BuisnessLogic.Entities.Enums;
using BookingSystem.BuisnessLogic.Validations;
using NodaTime;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Appointment : BaseEntity
    {
        public DateTime Date { get; set; } 
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
        public int AppointmentTypeId { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }





























        //  [Required]
        // [Display(Name = "Data wizyty")]
        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        // [AppointmentDateValidation(ErrorMessage = "Wybierz prawidłową datę (z przyszłości)")]
        // public DateTime Date { get; set; } 


        // [Required]
        // [Display(Name = "Początek wizyty")]
        // [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        // [DataType(DataType.Time)]
        // public LocalTime StartTime { get; set; }


        // [Required]
        // [Display(Name = "Koniec wizyty")]
        // [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        // [DataType(DataType.Time)]
        // public LocalTime EndTime { get; set; }

        // public string Description { get; set; }

        // [Required]
        // public AppointmentStatus AppointmentStatus { get; set; }

        // [Required]
        // public int AppointmentTypeId { get; set; }
        // [Required]
        // public AppointmentType AppointmentType { get; set; }

        // [Required]
        // public int CustomerId { get; set; }
        // [Required]
        // public Customer Customer { get; set; }

        // [Required]
        // public int EmployeeId { get; set; }
        // [Required]
        // public Employee Employee { get; set; }


    }
}