internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number");
        string input=Console.ReadLine();
        int num=Convert.ToInt32(input);
        if(num <2 )
        {
            Console.WriteLine("It's not a Prime Number");
            
        }
        else if(num==2)
        {
            Console.WriteLine("This is a Prime Number");
            
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
            if (isPrime)
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a Prime Number");
            }

                                
        }
    }
}