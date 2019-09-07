using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookingSystem.BuisnessLogic.Entities
{
    public abstract class BaseEntity
    {
        // [Key]
        public int Id { get; set; }


    }
}
