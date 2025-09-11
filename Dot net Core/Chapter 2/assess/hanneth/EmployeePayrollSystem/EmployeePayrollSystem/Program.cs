using EmployeePayrollSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        string opt;
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        do
        {
            Console.WriteLine("1.Full time employee");
            Console.WriteLine("2.Part Time Employee");
            Console.WriteLine("Select choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        fullTimeEmployee.GetEmployeeId();
                        fullTimeEmployee.GetName();
                        //fullTimeEmployee.GetBasicSalary();
                        fullTimeEmployee.CalculateSalary();
                        break;
                    }
                case 2:
                    {
                        partTimeEmployee.GetEmployeeId();
                        partTimeEmployee.GetName();
                        // partTimeEmployee.GetBasicSalary();   
                        partTimeEmployee.CalculateSalary();
                        break;
                    }
            }
            Console.WriteLine("do you want to continue  y/n");
             opt = Console.ReadLine();
        } while (opt == "y");
    }
    }