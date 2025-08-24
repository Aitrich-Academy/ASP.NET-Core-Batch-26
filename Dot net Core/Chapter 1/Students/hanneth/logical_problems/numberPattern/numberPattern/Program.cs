internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Enter rows");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + "\t");
            }
            Console.WriteLine();
        }

    }
}