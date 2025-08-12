enum Days
{
    Sunday,
    Monday,
    Tuesday
}
public class Program
{
    static void Main()
    {
        Days today = Days.Monday;
        Console.WriteLine("Today is: " + today);         // Output: Today is: Monday
        Console.WriteLine("Value: " + (int)today);       // Output: Value: 1
    }
}
