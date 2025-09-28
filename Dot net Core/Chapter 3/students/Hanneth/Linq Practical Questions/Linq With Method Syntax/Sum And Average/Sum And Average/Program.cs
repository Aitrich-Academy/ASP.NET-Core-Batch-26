internal class Program
{
    private static void Main(string[] args)
    {
        List<int> prices= new List<int> { 123,134,432,23,54,678,900};
        var sum= prices.Sum();
        var average= prices.Average();
        Console.WriteLine("Sum of prices:" + sum);
        Console.WriteLine("Average of prices : " + average);
    }
}