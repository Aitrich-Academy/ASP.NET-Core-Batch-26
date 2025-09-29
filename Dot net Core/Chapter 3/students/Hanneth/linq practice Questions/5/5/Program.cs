internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1,2,1,3,2,4,5,6,4,7,8,6,7,9};
        IEnumerable<int> distinctnumbers = numbers.Distinct();
        foreach (int i in distinctnumbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Contains 4: " + numbers.Contains(4));
    }
}