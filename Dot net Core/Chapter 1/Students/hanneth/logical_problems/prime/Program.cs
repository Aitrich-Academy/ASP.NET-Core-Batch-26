internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number to check prime");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        bool isPrime = true;
        if (num < 1 || num == 0)
        {
            Console.WriteLine("not prime");
        }
        else if (num == 1)
        {
            Console.WriteLine("Neither Prime nor composite");
        }
        else if (num == 2)
        {
            Console.WriteLine("The only even prime");
        }
        else
        {
            for (int i = 2; i < num ; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                   
                    break;
                }
               
            }
            if (isPrime)
            {
                Console.WriteLine("Number " + num + " is  prime");
            }

            else
            {
                Console.WriteLine("Number " + num + " is not prime");
            }
            Console.ReadKey();
        }
    }
}