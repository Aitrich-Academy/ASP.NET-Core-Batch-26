internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inverted Star Pattern");
        for(int i=1;i<6;i++)
        {
            for(int j=6;j>i;j--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}