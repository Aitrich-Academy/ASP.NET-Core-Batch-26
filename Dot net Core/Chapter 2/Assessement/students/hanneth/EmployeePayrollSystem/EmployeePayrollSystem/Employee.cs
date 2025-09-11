using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public abstract class Employee
    {
       private string employeeid;
       private string name;
       private double basicSalary;
           public string EmployeeId {  get { return employeeid; } set { employeeid = value; } }
        public string Name { get { return name; } set { name = value; } }
            public double BasicSalary { get; set; }
        public Employee() { }
        public Employee(string employeeid, string name, double basicSalary)
        {
            this.employeeid = employeeid;
            Name = name;
            BasicSalary = basicSalary;
           
        }
       public void  GetEmployeeId()
        {
            Console.WriteLine("Enter employee id");
            employeeid = Console.ReadLine();
        }
         public double GetBasicSalary()
        {
           Console.WriteLine("Enter basic salary");
            basicSalary=Convert.ToInt64(Console.ReadLine());
            return basicSalary;
        }
          public void GetName()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
      public double SetBasicSalary(double Amount)
        {
            basicSalary=Amount;
            return basicSalary;
        }
        public abstract void CalculateSalary();

    }
}
