using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Dog : IPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog(string name, int age, string Breed,string color)
        {
            Name = name;
            Age = age;
            this.Breed = Breed;
            Color= color;

        }
    }
}
