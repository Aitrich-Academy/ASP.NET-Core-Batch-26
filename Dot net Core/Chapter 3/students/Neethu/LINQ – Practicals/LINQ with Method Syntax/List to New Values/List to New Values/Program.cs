internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers= new List<int> { 1,2,3,4,5,6,7,8,9,10};
        var squares = numbers.Select(n=>n*n).ToList();
        Console.WriteLine("Squared numbers");
        foreach(int i in squares)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n Original list of numbers");
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}