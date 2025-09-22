internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers= new List<int> { 1,2,3,4,5,6,7,8,9,10};
        var result = numbers.Where(n => n > 5);
        foreach(int n in result)
        {
            Console.WriteLine(n);
        }
    }
}