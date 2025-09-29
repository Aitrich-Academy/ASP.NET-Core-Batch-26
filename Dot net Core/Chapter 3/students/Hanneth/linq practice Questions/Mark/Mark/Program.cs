
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> marks= new List<int> { 50,55,56,57,68,99,98,78};
        int mark = marks.First(m => m > 60);
            Console.WriteLine($"first Mark greater than 60 is: {mark}");
        Console.WriteLine($"Last mark less than 60 is : {marks.Last(m => m < 60)}");   
    }
}