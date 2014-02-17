using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public abstract class DogBreed
    {
        private static readonly List<DogBreed> _dogBreeds = new List<DogBreed> { new SmallDog(), new MediumDog(), new Beast() };

        public int Id { get; set; }
        public virtual BaseCosts BaseCosts { get; set; }
        public String BreedName { get; set; }

        // Not good code. Fire this developer!
        public static DogBreed GetBreedByName(string dogBreedName)
        {
            return _dogBreeds.FirstOrDefault(dogBreed => dogBreed.BreedName == dogBreedName);
        }

        public decimal GetCostOfCare(Booking booking)
        {
            return BaseCosts.GetSum(booking);
        }
    }
}
