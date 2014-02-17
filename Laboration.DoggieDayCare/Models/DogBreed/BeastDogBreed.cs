using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class Beast : DogBreed
    {
        public override string BreedName
        {
            get { return "Beast"; }
        }

        public Beast()
        {
            BaseCosts = BaseCosts.GetSpecialOffer();
        }

        public string DogBreed
        {
            get { return "Beast"; }
        }
    }
}