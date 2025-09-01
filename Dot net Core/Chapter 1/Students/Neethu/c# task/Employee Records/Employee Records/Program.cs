using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    struct Employee
    {
        public int EmpID;
        public string Name;
        public double Salary;
    }
    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[4];
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Enter the Employee ID");
            employees[i].EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee name");
            employees[i].Name = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            employees[i].Salary= Convert.ToDouble(Console.ReadLine());

        }
        Employee HighestPaid=employees[0];
        for(int i = 0;i < employees.Length;i++)
        {

            if (employees[i].Salary > HighestPaid.Salary)
            {
                HighestPaid = employees[i];
            }
                
        }
        Console.WriteLine("Employee with Highest Salary is:");
        Console.WriteLine("Employee ID: " + HighestPaid.EmpID);
        Console.WriteLine("Employee Name: " +HighestPaid.Name);
        Console.WriteLine("Salary: " + HighestPaid.Salary);

    }
}