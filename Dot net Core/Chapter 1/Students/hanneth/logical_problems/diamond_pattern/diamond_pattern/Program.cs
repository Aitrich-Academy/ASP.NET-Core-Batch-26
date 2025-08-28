internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello,enter the number of stars in middle row");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {   for(int k=input; k > i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {   
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for(int i = input-1;i > 0;i--)
        {
            for(int k=input; k > i;k--)
            {
                Console.Write(" ");
            }
            for(int j=0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}