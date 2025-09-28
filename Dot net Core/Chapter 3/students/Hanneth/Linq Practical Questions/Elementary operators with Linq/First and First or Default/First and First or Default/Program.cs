internal class Program
{
    private static void Main(string[] args)
    {
        List<int> ages=new List<int>{ 10, 25, 67, 82, 11, 1, 2, 5, 7, 22, 34 };
        var firstageabove30=ages.First(a=>a>30);
        Console.WriteLine("First age above 30 is " + firstageabove30);
        var firstordefaultageabove100=ages.FirstOrDefault(a=>a>100);
        Console.WriteLine("First or default age above 100 is "+firstordefaultageabove100);
    }
}