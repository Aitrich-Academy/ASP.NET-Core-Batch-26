internal class Program
{
    private static void Main(string[] args)
    {
        List <int> numbers = new List<int> { 45,22,78,10,53,2,75};
        var result = numbers.Where(n => n % 2 != 0).Select(n => n * n);
        Console.WriteLine("Square of odd nmbers in the list:");
        foreach(int n in result)
        {
            Console.WriteLine(n);
        }
    }
}