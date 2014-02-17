using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class BaseCosts
    {
        private static readonly BaseCosts _defaultBaseCosts = new BaseCosts()
        {
            Title = "Default", 
            PerDayOfCare = 200, 
            PerKiloGramOfFood = 50, 
            HousingFactor = 1M, 
            FearFactor = 0M
        };

        private static readonly BaseCosts _mediumBaseCosts = new BaseCosts()
        {
            Title = "Medium",
            PerDayOfCare = 200,
            PerKiloGramOfFood = 50,
            HousingFactor = 1.3M,
            FearFactor = 1M
        };

        private static readonly BaseCosts _ostermalmBaseCosts = new BaseCosts()
        {
            Title = "Special",
            PerDayOfCare = 200,
            PerKiloGramOfFood = 50,
            HousingFactor = 1.5M,
            FearFactor = 1.5M
        };

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal PerDayOfCare { get; set; }
        public decimal PerKiloGramOfFood { get; set; }
        public decimal HousingFactor { get; set; }
        public decimal FearFactor { get; set; }

        public decimal GetSum(Booking booking)
        {
            var daySpanAsDecimal = Convert.ToDecimal((booking.CheckOut - booking.CheckIn).TotalDays);
            var housingCost = daySpanAsDecimal * PerDayOfCare * HousingFactor;

            var foodCost = PerKiloGramOfFood * (booking.CheckInFoodWeight - booking.CheckOutFoodWeight) * FearFactor;

            return housingCost + foodCost;
        }

        public static BaseCosts GetDefaultBaseCosts()
        {
            return _defaultBaseCosts;
        }

        public static BaseCosts GetMediumBaseCosts()
        {
            return _mediumBaseCosts;
        }

        public static BaseCosts GetSpecialOffer()
        {
            return _ostermalmBaseCosts;
        }
    }
}