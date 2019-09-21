using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem.Infrastructure
{
    public static class LocalTimeTools
    {

        public static DateTime ToDateTime(this LocalTime localTime)
        { 
            return new DateTime(0,0,0,localTime.Hour, localTime.Minute, localTime.Second);
        }


    }
}
