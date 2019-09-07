using System.ComponentModel;

namespace BookingSystem.BuisnessLogic.Entities.Enums
{
    public enum AppointmentStatus
    {
        [Description("Odwołana")]
        Canceled = 1,
        [Description("Odbyta")]
        Came = 2,
        [Description("Aktywna")]
        Active = 3
    }
}