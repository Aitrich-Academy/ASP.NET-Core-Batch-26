using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class PetSeller
    {
        private Pet[] petsForSale;

        public PetSeller(Pet[] petsForSale)
        {
            this.petsForSale = petsForSale;
        }
        public void DisplayAvailablePets()
        {
            Console.WriteLine("Pets available for sale:");
            foreach(Pet pet in petsForSale)
            {
                pet.DisplayInfo();
            }
        }
    }
}
