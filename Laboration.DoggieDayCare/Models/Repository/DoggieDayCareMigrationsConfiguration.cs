using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class DoggieDayCareMigrationsConfiguration : DbMigrationsConfiguration<DoggieDayCareContext>
    {
        public DoggieDayCareMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DoggieDayCareContext context)
        {
            base.Seed(context);

            if (!context.DogBreeds.Any())
            {
                context.DogBreeds.Add(new SmallDog());
                context.DogBreeds.Add(new MediumDog());
                context.DogBreeds.Add(new Beast());   
            }

            if (!context.BaseCostses.Any())
            {
                context.BaseCostses.Add(BaseCosts.GetDefaultBaseCosts());
                context.BaseCostses.Add(BaseCosts.GetMediumBaseCosts());
                context.BaseCostses.Add(BaseCosts.GetSpecialOffer());
            }
        }
    }
}