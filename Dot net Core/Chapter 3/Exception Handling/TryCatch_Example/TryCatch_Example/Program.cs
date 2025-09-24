internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int num = 10;
            int zero = 0;
            int result = num / zero; 
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
        }
    }
}