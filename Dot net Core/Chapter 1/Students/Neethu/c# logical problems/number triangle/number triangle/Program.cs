internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Number patterned Triangle");
        for(int i = 1;i<6;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}