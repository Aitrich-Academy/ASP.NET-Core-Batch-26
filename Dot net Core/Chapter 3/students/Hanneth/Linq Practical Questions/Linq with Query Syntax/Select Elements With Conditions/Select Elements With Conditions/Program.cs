class Employee
{
   public string name;
  public  double Salary;
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> Employeelist = new List<Employee>
        {
            new Employee{name="abcd",Salary=100000},
             new Employee{name="bcd",Salary=50000},
              new Employee{name="sabcd",Salary=200000},
               new Employee{name="fabcd",Salary=10000},
                new Employee{name="kabcd",Salary=20000},
        };
        var emp=from em in Employeelist where em.Salary>20000  select em;
        Console.WriteLine("employees with salary greater than 20000 are :");
        foreach( Employee employee in emp )
        {
            Console.WriteLine($"{employee.name}  :  {employee.Salary}");
        }
    }
}