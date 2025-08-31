using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class Pet
    {
        private string name;
        private int age;
        private string breed;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public Pet(string name, int age , string breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {name}, Breed: {breed}, Age: {age}");
        }
    }
}
