using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    internal class PartTimeEmployee:Employee
    {
        public override void CalculateSalary()
        {
            double gbs = GetBasicSalary();
            double sbs = SetBasicSalary(gbs);
            //double bs= SetBasicSalary();

            Console.WriteLine($"Salary: {sbs}");
        }
    }
}
