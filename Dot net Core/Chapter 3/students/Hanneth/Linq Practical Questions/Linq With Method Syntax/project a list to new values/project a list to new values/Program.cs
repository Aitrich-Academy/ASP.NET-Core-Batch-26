using System.Data.SqlTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers=new List<int> { 1,2,3,4,5,6,7,8,9,10};
        var squares = numbers.Select(n=>n*n).ToList();
        Console.WriteLine("Original list ");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("Transformed List");
        foreach(var sq in squares)
        {
            Console.WriteLine(sq);
        }
    }
}