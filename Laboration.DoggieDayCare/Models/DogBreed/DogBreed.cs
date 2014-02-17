﻿using System;
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
        public abstract String BreedName { get; }
        public abstract decimal GetCostOfCare(Booking booking);

        protected DogBreed()
        {
            BaseCosts = BaseCosts.GetDefaultBaseCosts();
        }

        // Not good code. Fire this developer!
        public static DogBreed GetBreedByName(string dogBreedName)
        {
            return _dogBreeds.FirstOrDefault(dogBreed => dogBreed.BreedName == dogBreedName);
        }
    }
}