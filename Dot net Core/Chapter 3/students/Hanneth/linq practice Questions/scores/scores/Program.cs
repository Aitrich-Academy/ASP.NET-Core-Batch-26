internal class Program
{
    private static void Main(string[] args)
    {
        List<int> scores = new List<int> { 89,67,45,78,99,78,66};
        Console.WriteLine("Maximum of scores : " +scores.Max());
        Console.WriteLine("Minimum of scores : "+scores.Min());
        Console.WriteLine("Average of scores : "+scores.Average());
    }
}