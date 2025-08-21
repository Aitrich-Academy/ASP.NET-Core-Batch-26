internal class Program
{
    private static void Main(string[] args)
    {
        int flag=0;
        string ch;
        do
        {
            Console.WriteLine("Hello, Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 2)
            {
                Console.WriteLine("The only even prime");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The given number is even");
                Console.WriteLine("The given number is not prime");
            }
            else
            {
                Console.WriteLine("The given number is odd");
                for (int i = 2; i <= num/2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                    if (flag==0)
                    {
                        Console.WriteLine("Given number is prime");
                    }
                    else
                    {
                        Console.WriteLine("Given number is not  prime");
                    }
            }
            Console.WriteLine("Do you want to continue(y/n)");
            ch= Console.ReadLine();
        } while (ch == "y");
    }
}