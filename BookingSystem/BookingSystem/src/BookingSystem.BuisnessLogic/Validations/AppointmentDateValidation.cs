using System;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Validations
{
    public class AppointmentDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            DateTime today = DateTime.Now;
            if (date.Date.Date.CompareTo(today.Date) >= 0)
                return true;
            else
                return false;
        }
    }
}