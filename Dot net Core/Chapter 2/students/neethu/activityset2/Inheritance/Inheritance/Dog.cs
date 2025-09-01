using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog:Pet
    {
        private string FavouriteToy;
        public Dog(string name,int age, string breed, string favouriteToy) : base(name, age, breed)
        {
            FavouriteToy = favouriteToy;
        }
        public void DisplayDogDetails()
        {
            DisplayDetails();
            Console.WriteLine($"Favourite Toy: {FavouriteToy}");
        }
    }
}
