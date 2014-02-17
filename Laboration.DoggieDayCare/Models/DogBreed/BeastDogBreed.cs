using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class Beast : DogBreed
    {
        public Beast()
        {
            BaseCosts = BaseCosts.GetSpecialOffer();
            BreedName = "Beast";
        }
    }
}