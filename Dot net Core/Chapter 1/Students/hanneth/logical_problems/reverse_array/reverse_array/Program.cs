internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int i, countEven = 0, countOdd = 0;
        Console.WriteLine("Hello, enter the number of elements in the array!");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + n + " elements");
        for (i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = n-1; i >= 0; i--)
        {
            Console.WriteLine("Reversed array is" + a[i]);
        }
    }
}