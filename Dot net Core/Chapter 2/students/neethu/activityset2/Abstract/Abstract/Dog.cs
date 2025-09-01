using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Dog:Pet
    {
        public Dog(string name,int age,string Breed) : base(name,age,Breed)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

    }
}
