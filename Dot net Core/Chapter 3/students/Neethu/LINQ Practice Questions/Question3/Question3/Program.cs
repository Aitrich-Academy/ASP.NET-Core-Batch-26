internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string,int> employees= new Dictionary<string,int>
        {   {"John",28},
            {"Raj",45 },
            {"Greeshma",15 },
            {"Meena",25 },
            {"Miya",50 }
        };
        Console.WriteLine("Employees with age above 30");
        var agelist=from employee in employees where employee.Value>30 select employee.Key;
        foreach(var emp in agelist)
        {
            Console.WriteLine(emp);
        }
    }
}