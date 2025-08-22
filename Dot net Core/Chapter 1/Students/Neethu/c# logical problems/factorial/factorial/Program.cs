internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        double factorial = 1;
        while (num > 0)
        {
            factorial = factorial * num;
            num--;
        }
        Console.WriteLine("Factorial of the number is :" + factorial);
    }
}