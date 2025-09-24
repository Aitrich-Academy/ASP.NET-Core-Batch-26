internal class Program
{
    private static void Main(string[] args)
    {
  
            try
            {
                int age = 15;

                if (age < 18)
                {
                    // Throwing a custom application exception
                    throw new ApplicationException("Age must be 18 or above to register.");
                }

                Console.WriteLine("Registration successful.");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Application Error: " + ex.Message);
            }
        }
    }
