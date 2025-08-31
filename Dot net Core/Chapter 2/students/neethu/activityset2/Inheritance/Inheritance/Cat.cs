using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat:Pet
    {
        private bool isLongHair;

        public Cat(string name, int age, string breed, bool isLongHair   ) : base(name, age, breed)
        {
            this.isLongHair = isLongHair;
        }
        public void DisplayCatDetails()
        {
            DisplayDetails();
            Console.WriteLine($"Long Hair: {isLongHair}");
        }

    }
}
