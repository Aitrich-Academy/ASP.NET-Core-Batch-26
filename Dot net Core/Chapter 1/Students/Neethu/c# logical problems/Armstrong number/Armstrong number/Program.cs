using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any number");
        int num=Convert.ToInt32(Console.ReadLine());
        int originalNum = num;
        int digits = num.ToString().Length;
        int sum = 0;
        while(num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;

        }
        if(sum==originalNum)
        {
            Console.WriteLine("This is an armstrong Number");
        }
        else
        {
            Console.WriteLine("This is not an Armstrong Number");
        }
    }
}