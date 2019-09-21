using System;
using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class WorkingHour : BaseEntity
    {
        public DayOfWeek DayOfWeek { get; set; }
        public string OpenHour { get; set; }
        public string CloseHour { get; set; }


























        // /// <summary>
        // /// Dzień tygodnia
        // /// </summary>
        // public DayOfWeek DayOfWeek { get; set; }

        // /// <summary>
        // /// Godzina otwarcia
        // /// </summary>
        // [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        // public DateTime StartHour { get; set; }

        // /// <summary>
        // /// Godzina zamknieca
        // /// </summary>
        // [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        // public DateTime CloseHour { get; set; }
    }
}