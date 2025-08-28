internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int max;
        Console.WriteLine("Hello, Enter the number of elements in the array!");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + input + " elements");
        for (int i = 0; i < input; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        max = a[0];
        for (int i = 0; i < input; i++)
        {
                if (a[i] > max)
                {
                    max = a[i];
                }
            
        }

        Console.WriteLine("Largest is " + max);
    }
}