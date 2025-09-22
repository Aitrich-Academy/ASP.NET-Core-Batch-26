internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 7,1,3,9,2,4};
        var result = numbers.OrderBy(n => n);
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}