using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Diamond pattern!");
        Console.WriteLine("Enter the number of rows needed");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n-i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        for(int j=n;j>0;j--)
        {
            Console.Write(new string(' ',n-j));
            Console.WriteLine(new string('*', 2*j-1));
           
        }
    }
}