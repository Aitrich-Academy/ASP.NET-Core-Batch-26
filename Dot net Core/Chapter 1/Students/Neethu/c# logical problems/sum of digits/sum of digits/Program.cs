internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any Number!");
        int num=Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while(num > 0)
        {
            int digit = num % 10;
            sum += digit;
            num /= 10;
        }
        Console.WriteLine("Sum of the digits of the number is :" + sum);
    }
}