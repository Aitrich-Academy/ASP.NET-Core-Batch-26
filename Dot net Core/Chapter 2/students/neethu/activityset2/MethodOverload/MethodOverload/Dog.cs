using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class Dog:Pet
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed):base(name,age)
        {
            Breed = breed;
        }
        public void DisplayInfo(bool includeBreed)
        {
            if (includeBreed)
                Console.WriteLine($"Name: {Name}, Age: {Age}, Breed: {Breed}");
            else
                DisplayInfo();
        }
    }
}
