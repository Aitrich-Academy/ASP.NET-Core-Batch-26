internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 numbers!");
        int[] numbers=new int[5];
        for(int i=0; i<5; i++)
        {
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Reversed array is");
        for(int i= numbers.Length-1;i>=0;i--)
        {
            Console.Write(numbers[i]+" " );
        }
    }
}