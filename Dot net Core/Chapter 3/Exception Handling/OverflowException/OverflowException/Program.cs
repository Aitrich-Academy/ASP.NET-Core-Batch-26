internal class Program
{
    private static void Main(string[] args)
    {
        checked
        {
            int a = int.MaxValue;
            int result = a + 1; 
            Console.WriteLine(result);
        }
    }
}