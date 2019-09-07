using System.ComponentModel;

namespace BookingSystem.BuisnessLogic.Entities.Enums
{
    public enum  DayOfWeek
    {
        [Description("Poniedziałek")]
        Monday = 1,

        [Description("Wtorek")]
        Tuesday = 2,

        [Description("Środa")]
        Wednesday = 3,

        [Description("Czwartek")]
        Thursday = 4,

        [Description("Piątek")]
        Friday = 5,

        [Description("Sobota")]
        Saturday = 6,
        
        [Description("Niedziela")]
        Sunday = 7,
    }
}