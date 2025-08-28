internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string input = Console.ReadLine();
        int len = input.Length;
        int num = Convert.ToInt32(input);
        int n = num, sum = 0;
        for (int i = 0; i < len; i++)
        {
            int a = num % 10;
            sum += a * a * a;
            num = num / 10;
        }
        if (sum == n)
        {
            Console.WriteLine("Armstrong!!!");
        }
        else
        {
            Console.WriteLine("Not Armstrong");
        }
    }
}