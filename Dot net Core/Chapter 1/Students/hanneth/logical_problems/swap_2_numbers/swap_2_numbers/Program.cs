internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello , Enter 2 numbers!");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a= a - b;
        Console.WriteLine("Value of a&b after swapping a = "+a+"b = "+b);
    }
}