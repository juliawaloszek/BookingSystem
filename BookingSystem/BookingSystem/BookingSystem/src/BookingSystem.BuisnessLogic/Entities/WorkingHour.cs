using System;
using System.ComponentModel.DataAnnotations;

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
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        public DateTime StartHour { get; set; }

        /// <summary>
        /// Godzina zamknieca
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        public DateTime CloseHour { get; set; }
    }
}