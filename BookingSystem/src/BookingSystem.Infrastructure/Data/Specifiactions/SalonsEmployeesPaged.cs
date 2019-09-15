using BookingSystem.BuisnessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookingSystem.Infrastructure.Data.Specifiactions
{
    public class SalonsEmployeesPaged : BaseSpecification<Employee>
    {
        public SalonsEmployeesPaged(int salonId, int pageSize, int pageNumber) : base(x=>x.SalonId == salonId)
        {
            ApplyPaging((pageNumber - 1) * pageSize, pageSize);

        }
    }
}
