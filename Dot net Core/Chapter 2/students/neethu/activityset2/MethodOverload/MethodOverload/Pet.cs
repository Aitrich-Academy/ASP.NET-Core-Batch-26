using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }    

        public Pet(string name, int age)
        {
            Name = name; Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
