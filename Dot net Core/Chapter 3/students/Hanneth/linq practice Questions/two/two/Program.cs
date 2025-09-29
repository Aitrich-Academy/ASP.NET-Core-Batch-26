using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
       List<int> ints = new List<int> { 1,45,32,56,78,94,90,100};
        var even=from num in ints where num%2==0 select num;
        int evenCount=even.Count();
        foreach(int num in even) { Console.WriteLine(num); }
        Console.WriteLine();
        Console.WriteLine($"Total even numbers is : {evenCount}");
    }
}