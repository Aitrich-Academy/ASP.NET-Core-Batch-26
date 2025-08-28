internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number!!!");
        string input = Console.ReadLine();
        int len = input.Length;
        int num = Convert.ToInt32(input);
        int a = num;
        string c = null;
        for (int i = 0; i < len; i++)
        {
            int b = num % 10;
            c = c + b;
            num = num / 10;
        }
        if (Convert.ToInt32(c) == a)
        {
            Console.WriteLine("Palindrome!!!!!!!!");
        }
        else
        {
            Console.WriteLine("Not Palindrome!!!!!");
        }
    }
}