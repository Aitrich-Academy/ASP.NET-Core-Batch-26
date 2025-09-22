internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result=from num in numbers where num > 5 select num;
        foreach(int num in result)
        {
            Console.WriteLine(num);
        }
    }
}