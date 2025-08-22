internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Right Angled Triangle");
        for(int i=1;i<5;i++)
        {
            for(int j=0;j<i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("\n");
        }
    }
}