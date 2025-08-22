using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started");
        }

    }
}
