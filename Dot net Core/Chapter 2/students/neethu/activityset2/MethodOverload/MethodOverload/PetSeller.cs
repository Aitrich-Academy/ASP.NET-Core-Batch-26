using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class PetSeller
    {
        private string sellerName;
        private Pet pet;

        public PetSeller(string sellerName, Pet pet)
        {
            this.sellerName = sellerName;
            this.pet = pet;
        }
        public void SellPet()
        {
            Console.WriteLine($"{sellerName} is selling:");
            pet.DisplayInfo();
        }
    }
}
