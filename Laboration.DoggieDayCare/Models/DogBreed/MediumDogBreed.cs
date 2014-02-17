using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class MediumDog : DogBreed
    {
        public MediumDog()
        {
            BaseCosts = BaseCosts.GetMediumBaseCosts();
            BreedName = "Medium";
        }
    }
}