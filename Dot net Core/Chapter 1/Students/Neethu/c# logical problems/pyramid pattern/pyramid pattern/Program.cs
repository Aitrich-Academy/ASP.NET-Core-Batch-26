internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("pyramid pattern !");
        Console.WriteLine("Enter the number of rows needed for pyramid");
        int rows=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=rows;i++)
        {
            Console.Write(new string(' ',rows-i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}