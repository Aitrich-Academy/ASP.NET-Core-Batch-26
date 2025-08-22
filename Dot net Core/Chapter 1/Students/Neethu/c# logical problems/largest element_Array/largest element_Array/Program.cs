using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 numbers");
        int[] numbers=new int[5];
        
        for(int i=0; i<numbers.Length; i++)
        {
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        int largest = numbers[0];
        for (int i=0;i<numbers.Length;i++)
        {
          if(numbers[i]>largest)
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine("Largest Number is:" + largest);
    }
}