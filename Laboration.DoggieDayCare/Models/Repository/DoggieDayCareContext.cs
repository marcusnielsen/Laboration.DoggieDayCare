using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class DoggieDayCareContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BaseCosts> BaseCostses { get; set; } // Should rename but "Costses" was a too awesome autosuggestion! *Gollum* *Gollum*
        public DbSet<DogBreed> DogBreeds { get; set; }

        public DoggieDayCareContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<DoggieDayCareContext, DoggieDayCareMigrationsConfiguration>()
                );
        }
    }
}