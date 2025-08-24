internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string input=Console.ReadLine();
        int len = input.Length, sum = 0;
        int n=Convert.ToInt32(input);
        for (int i = 0; i < n; i++)
        {
            int a = n % 10;
            sum += a;
            n = n / 10;
        }
        Console.WriteLine("Sum of digits is"+sum);
    }
}