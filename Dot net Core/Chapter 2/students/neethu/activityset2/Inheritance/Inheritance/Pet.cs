using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Pet
    {
        protected string Name;
        protected int Age;
        protected string Breed;

        

        public Pet(string name, int age, string breed  )
        {
            Name = name;
            Age = age;
            Breed = breed;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
