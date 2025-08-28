internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int max;
        Console.WriteLine("Hello, Enter the number of elements in the array!");
        int input=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + input + "elements");
        for (int i = 0; i < input; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                if (a[i] > a[j])
                {
                    max = a[i];
                    Console.WriteLine("Largest number in the array is", max);
                }
            }
        }
       
                    
    }
}