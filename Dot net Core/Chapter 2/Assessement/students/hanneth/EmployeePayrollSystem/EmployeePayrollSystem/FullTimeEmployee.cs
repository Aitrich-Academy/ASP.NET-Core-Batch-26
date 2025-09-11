using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    internal class FullTimeEmployee:Employee
    {
        public override void CalculateSalary()
        {
            double gbs=GetBasicSalary();
            double sbs = SetBasicSalary(gbs);
            double bonus = sbs * .2;
            sbs = sbs+bonus;
            Console.WriteLine($"Salary={sbs}");
        }
    }
}
