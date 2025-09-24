using Elements_with_Conditions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employees> employeelist = new List<Employees>
        {
            new Employees{Name="John", Salary=8500},
            new Employees{Name="Raj", Salary=5000},
            new Employees{Name="Miya", Salary=15000},
            new Employees{Name="Jacob", Salary=25000},
            new Employees{Name="Neethu", Salary=10000},
            new Employees{Name="Jeanu", Salary=4000},
            new Employees{Name="Alice", Salary=5500}
        };
        var orderbySalary=from employees in employeelist where employees.Salary>6000 select employees;
        Console.WriteLine("Employees having salary more than RS 6000");
        foreach (var employee in orderbySalary)
        {
            Console.WriteLine($"Name:{employee.Name}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }
    }
}