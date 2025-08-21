internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter how many times to print: ");
        string input = Console.ReadLine();
        int count = Convert.ToInt32(input); // Using Convert.ToInt32 for safety

        int i = 1;

        while (i <= count)
        {
            Console.WriteLine("Number: " + i);
            i++;
        }
    }
}