using CFA_Employee.Data;
using CFA_Employee.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exitprogram=false;
        string ch;
        using(var context=new EmpDbContext())
        {
            
            while(!exitprogram)
            {
                Console.WriteLine("1.Register Employee");
                Console.WriteLine("2. Display Employee details");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose any Option");
                ch= Console.ReadLine();
                switch(ch)
                {
                    case "1":
                        Console.WriteLine("Please Enter Employee's Name");
                        string name=Console.ReadLine();
                        Console.WriteLine("Please Enter Employee's Salary");
                        string salary=Console.ReadLine();
                        Employee newEmployee=new Employee(name,salary);
                        context.employees.Add(newEmployee);   
                        context.SaveChanges();
                        Console.WriteLine("New Product got added");
                        break;
                    case "2":
                        Console.WriteLine("Employee Details");
                        var Allemployees=context.employees.ToList();
                        foreach(var emp in Allemployees)
                        {
                            Console.WriteLine($"Id:{emp.Id}----Name:{emp.Name}-----Salary:{emp.Salary}");
                        }
                        break;
                    case "3":
                        exitprogram=true;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;


                }

            }
        }
    }
}