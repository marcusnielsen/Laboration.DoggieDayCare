using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class SmallDog : DogBreed
    {
        public override string BreedName
        {
            get { return "Small"; }
        }

        public override decimal GetCostOfCare(Booking booking)
        {
                var daySpanAsDecimal = Convert.ToDecimal((booking.CheckOut.ToUniversalTime() - booking.CheckIn.ToUniversalTime()).TotalDays);
                return daySpanAsDecimal * BaseCosts.PerDayOfCare;
        }
    }
}