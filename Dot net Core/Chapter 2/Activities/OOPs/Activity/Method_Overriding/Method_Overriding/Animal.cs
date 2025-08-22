using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    internal class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
