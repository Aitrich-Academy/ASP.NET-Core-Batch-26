internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Odd or Even!");
        Console.WriteLine("Enter 5 Numbers");
        int[] numbers= new int[5];
        int odd = 0 , even=0; 
        for(int i=0;i<5;i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());   
        }

        for(int i=0;i<numbers.Length;i++)
        {
            if (numbers[i]%2==0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine("Frequency of Odd numbers: " + odd);
        Console.WriteLine("Frequency of Even numbers: " + even);
    }
}