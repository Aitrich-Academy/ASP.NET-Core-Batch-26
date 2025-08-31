using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class PetSeller:Pet
    {
        private Decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public PetSeller(string name, int age, string breed,  decimal price):base(name,age,breed)
        {
            this.price = price;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Price: {price:C}");
        }
    }
}
