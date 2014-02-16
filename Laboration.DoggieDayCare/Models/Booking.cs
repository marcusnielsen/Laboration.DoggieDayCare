using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public virtual DogBreed DogBreed { get; set; }
        public String OwnerCivicRegistrationNumber { get; set; }
        public String DogRegistrationNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public Decimal CheckInFoodWeight { get; set; }
        public DateTime CheckOut { get; set; }
        public Decimal CheckOutFoodWeight { get; set; }

        public Decimal CostSum
        {
            get
            {
                if (DogBreed == null || DogBreed.BaseCosts == null)
                {
                    return 0;
                }

                return DogBreed.GetCostOfCare(this);
            }
        }

        public Dictionary<string, string> Data { get; set; }
    }
}