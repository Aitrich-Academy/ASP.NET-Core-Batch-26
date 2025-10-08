using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_System
{
    public class PriceNegativeException:Exception
    {
        public PriceNegativeException() { }
        public PriceNegativeException(string message) : base(message) { }
    }
}
