internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a any Number!");
        int num=Convert.ToInt32(Console.ReadLine());
        int originalNum = num;
        int reverse = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reverse = reverse*10 + digit;
            num /= 10;

        }
        if (reverse == originalNum)
        {
            Console.WriteLine("This is a Palindrome Number");
        }
        else
        {
            Console.WriteLine("This is not a Palindrome Number");
        }
    }
}