using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class MediumDog : DogBreed
    {
        public override string BreedName
        {
            get { return "Medium"; }
        }

        public MediumDog()
        {
            BaseCosts = BaseCosts.GetMediumBaseCosts();
        }
    }
}