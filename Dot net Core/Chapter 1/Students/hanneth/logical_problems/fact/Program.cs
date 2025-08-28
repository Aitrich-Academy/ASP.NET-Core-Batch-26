internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to calculate the factorial");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("facorial of" + num + " is " + fact);
    }
}