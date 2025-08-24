internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter n");
        string n = Console.ReadLine();
        int limit = Convert.ToInt32(n);
        int a = 0, b = 1, c = 0;
        if (limit == 1)
        {
            Console.WriteLine("0");
        }
        else if (limit == 2)
        {
            Console.Write("0\t1");
        }
        else
        {
            Console.Write("0\t1\t");
            for (int i = 0; i < limit-2; i++)
            {
                c = a + b;
                Console.Write(c + "\t");
                a = b;
                b = c;
            }
        }
    }
}