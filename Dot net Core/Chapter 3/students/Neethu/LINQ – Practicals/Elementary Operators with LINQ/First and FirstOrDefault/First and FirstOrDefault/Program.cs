internal class Program
{
    private static void Main(string[] args)
    {
        List<int> ages = new List<int> { 25,10,5,80,55,76,54,20,33};
        var above30 = ages.First(n=>n>30);
        Console.WriteLine($"first age that is above 30 is:{above30}");
        var above100 = ages.FirstOrDefault(n => n > 100);
        if(above100==0)
        {
            Console.WriteLine("No age above 100 found ");

        }
        else
        {
            Console.WriteLine($"First age above 100 is: {above100}");
        }

    }
}