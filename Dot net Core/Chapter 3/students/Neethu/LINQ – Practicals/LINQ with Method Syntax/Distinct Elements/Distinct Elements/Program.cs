internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 5, 8, 6, 5, 7, 2, 7, 6, 1, 2 };
        var Distinctnum=numbers.Distinct();
        Console.WriteLine("Number list without duplicate numbers: ");
        foreach(int i  in Distinctnum)
        {
            Console.WriteLine(i);
        }
    }
}