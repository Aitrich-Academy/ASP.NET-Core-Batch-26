using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        private int _age;

        // Public property with getter and setter
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 5 && value <= 100)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;  // 0 means invalid
                }
            }
        }
        public void ShowAge()
        {
            if (_age > 0)
                Console.WriteLine("Student Age: " + Age);
            else
                Console.WriteLine("Invalid age entered.");
        }
    }
}
