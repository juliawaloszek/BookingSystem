using System;
using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class WorkingHour : BaseEntity
    {
        /// <summary>
        /// Dzień tygodnia
        /// </summary>
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Godzina otwarcia
        /// </summary>
        // [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        public LocalTime StartHour { get; set; }

        /// <summary>
        /// Godzina zamknieca
        /// </summary>
        // [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        public LocalTime CloseHour { get; set; }
    }
}