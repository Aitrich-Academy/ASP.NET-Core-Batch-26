internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Enter the rows");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int i = input; i >0; i--)
        {
            for (int k = input; k > i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();

        }
        
    }
}
