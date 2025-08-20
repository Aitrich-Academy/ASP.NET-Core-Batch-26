internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any Number");
        int num=Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while(num > 0)
        {
            int digit = num % 10;
            count++;
            num = num / 10;
        }
        Console.WriteLine("Number of digits in the number :"+count);
    }
}