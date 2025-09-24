internal class Program
{
    private static void Main(string[] args)
    {
        List <int> numbers = new List<int> { 4,5,8,6,5,7,2,7,6,1,2};
        var norepeat = numbers.Distinct();
        Console.WriteLine("Array list without duplicate numbers");
        foreach (int i in norepeat)
        {
            Console.WriteLine(i);
        }
        bool isfour=numbers.Contains(4);
        Console.WriteLine($"Do Number 4 available in list? {isfour}");

    }
}