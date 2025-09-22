internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1,2,3,4,5};
        var sum = numbers.Sum();
        Console.WriteLine("Sum is"+sum);
    }
}