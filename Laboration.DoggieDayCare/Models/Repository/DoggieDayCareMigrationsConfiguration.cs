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
    }
}