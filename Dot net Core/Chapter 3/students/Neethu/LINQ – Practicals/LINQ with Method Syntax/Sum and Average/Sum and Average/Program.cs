internal class Program
{
    private static void Main(string[] args)
    {
        List<double> Prices= new List<double> {45,85.06,56.85,47,34.50,99.99 };
        var sum=Prices.Sum();
        var average=Prices.Average();
        Console.WriteLine($"Sum of the Prices: {sum}");
        Console.WriteLine($"Average of the Prices: {average}");

    }
}