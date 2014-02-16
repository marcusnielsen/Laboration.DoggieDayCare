using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class BaseCosts
    {
        private static readonly BaseCosts _defaultBaseCosts = new BaseCosts() { Title = "Default", PerDayOfCare = 200, PerKiloGramOfFood = 50 };

        public int Id { get; set; }
        public string Title { get; set; }
        public Decimal PerDayOfCare { get; set; }
        public Decimal PerKiloGramOfFood { get; set; }

        public static BaseCosts GetDefaultBaseCosts()
        {
            return _defaultBaseCosts;
        }
    }
}