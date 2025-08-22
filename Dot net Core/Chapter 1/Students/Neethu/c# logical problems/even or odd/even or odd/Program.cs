internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any Number!");
        int num=Convert.ToInt32(Console.ReadLine());    
        if(num%2==0)
        {
            Console.WriteLine("This is an Even Number");
        }
        else
        {
            Console.WriteLine("This an Odd Number");
        }
    }
}