using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class AppointmentType :BaseEntity
    {

        [StringLength(60, MinimumLength = 3)]
        [Display(Name ="Nazwa usługi" )]
        public string Name { get; set; }


        [Display(Name ="Czas trwania usługi" )]
        public int Duration { get; set; }
    }
}