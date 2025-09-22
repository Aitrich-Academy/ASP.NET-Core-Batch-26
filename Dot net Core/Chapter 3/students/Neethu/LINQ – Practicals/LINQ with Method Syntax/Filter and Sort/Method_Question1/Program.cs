internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 45,85,53,29,78,49,67,82,60};
        var result = numbers.Where(n => n > 50).OrderByDescending(n => n);
        Console.WriteLine("Numbers greater than 50 in descending order");
        foreach(var n in result)
        {
            Console.WriteLine(n);

        }
    }
}