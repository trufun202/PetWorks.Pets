using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetWorks.Shared.Enumerations;
using PetWorks.Shared.Services.Interfaces;

namespace PetWorks.Pets.Fish.Services.Implementations
{
    public class CatService
        : IPetService
    {
        public bool CanHandle(PetType petType)
        {
            if (petType == PetType.Cat)
                return true;

            return false;
        }

        public List<string> GetPets()
        {
            return new List<string>()
            {
                "Persian",
                "Exotic Shorthair",
                "Maine Coon",
                "Ragdoll",
                "British Shorthair"
            };
        }
    }
}
