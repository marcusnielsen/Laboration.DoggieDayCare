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

        public SmallDog()
        {
            BaseCosts = BaseCosts.GetDefaultBaseCosts();
        }
    }
}