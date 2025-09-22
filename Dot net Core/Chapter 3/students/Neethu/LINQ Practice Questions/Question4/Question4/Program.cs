internal class Program
{
    private static void Main(string[] args)
    {
        List<int> marks= new List<int> { 45,82,50,78,90,35,65};
        Console.WriteLine("First mark greater than 60 using first()");
        var mark1 = marks.First(n=>n>60);
        Console.WriteLine(mark1);
        Console.WriteLine("First mark greater than 60 using firstOrDefault()");
        var mark2= marks.FirstOrDefault(n=>n>60);
        Console.WriteLine(mark2);
        Console.WriteLine("Last mark less than 60 using Last()");
        var mark3=marks.Last(n=>n<60);
        Console.WriteLine(mark3);
        Console.WriteLine("First mark greater than 60 using LastOrDefault()");
        var mark4 = marks.LastOrDefault(n=>n<60);
        Console.WriteLine(mark4);



    }
}