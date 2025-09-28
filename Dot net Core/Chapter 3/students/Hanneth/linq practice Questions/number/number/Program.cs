internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 34, 54, 21, 1, 3, 5, 7, 9, 89, 7 };
        var result=from num in numbers where num%2!=0 select num;
        foreach (int num in result)
        {
            Console.WriteLine($"odd nember in the list : {num} square of odd number :  {num * num}");
        }
    }
}