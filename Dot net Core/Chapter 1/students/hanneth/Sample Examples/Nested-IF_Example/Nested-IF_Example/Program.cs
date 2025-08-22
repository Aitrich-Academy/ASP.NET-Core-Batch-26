internal class Program
{
    private static void Main(string[] args)
    {
        int number = 15;

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Positive and Even");
            }
            else
            {
                Console.WriteLine("Positive and Odd");
            }
        }
        else
        {
            Console.WriteLine("Number is not positive");
        }
    }
}