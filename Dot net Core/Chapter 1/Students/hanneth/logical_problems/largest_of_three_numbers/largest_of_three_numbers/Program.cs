internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int c=Convert.ToInt32(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine(a + " is greater");
        }
        else if (b > c && b > a)
        {
            Console.WriteLine(b + " is greater");
        }
        else
        {
            Console.WriteLine(c + " is greater");
        }
    }
}