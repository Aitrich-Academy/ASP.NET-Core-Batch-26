using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    internal class Pet
    {
        public string Name;
        public string Type;
        public int Age;
        public double Price;

        public Pet(string name, string type, int age, double price)
        {
            Name = name;
            Type = type;
            Age = age;
            Price = price;
        }
        public Pet() { }
        public void Display()
        {
            Console.WriteLine($"Name:{Name} ");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
