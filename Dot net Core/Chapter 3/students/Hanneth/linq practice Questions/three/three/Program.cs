using System.Collections;
using System.Linq;
class Employee
{
   public string Name;
   public int age;
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{Name="Alice",age=38},
            new Employee{Name="Sukumaran",age=30},
            new Employee{Name="Santhosh",age =32},
            new Employee{Name="Mridul", age=24,}
        };
        var Names=from emp in employees where emp.age>30 select emp.Name;
        foreach (var name in Names)
        {
        Console.WriteLine($"Names of all employees age greater than 30 are : {name}");
        }
    }
}