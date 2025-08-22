internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        string ch;
        do
        {
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
            if (num < 2)
            {
                Console.WriteLine("The number is not Prime");
            }
            else if (num == 2)
            {
                Console.WriteLine("The number is Prime");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (!isPrime)
                {
                    Console.WriteLine("This number is not a Prime");
                }
                else
                {
                    Console.WriteLine("This number is Prime");
                }
            }
            Console.WriteLine("Do you want to check another number?(y/n)");
            ch = Console.ReadLine();
        } while (ch == "Y" || ch == "y");
    }
}