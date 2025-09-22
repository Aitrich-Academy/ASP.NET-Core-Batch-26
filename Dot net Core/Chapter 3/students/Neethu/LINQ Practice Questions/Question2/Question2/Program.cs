internal class Program
{
    private static void Main(string[] args)
    {
        List <int> numbers = new List<int> { 5,8,1,4,6,7,3};
        var result = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers are:");
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine($"Total count of even numbers: {result.Count()}");
    }
}