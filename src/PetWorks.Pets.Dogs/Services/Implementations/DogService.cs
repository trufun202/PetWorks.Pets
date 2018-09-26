using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetWorks.Shared.Enumerations;
using PetWorks.Shared.Services.Interfaces;

namespace PetWorks.Pets.Fish.Services.Implementations
{
    public class DogService
        : IPetService
    {
        public bool CanHandle(PetType petType)
        {
            if (petType == PetType.Dog)
                return true;

            return false;
        }

        public List<string> GetPets()
        {
            return new List<string>()
            {
                "Beagle",
                "Poodle",
                "German Shepherd",
                "Bulldog",
                "Labrador Retriever"
            };
        }
    }
}
