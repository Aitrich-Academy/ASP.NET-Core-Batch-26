internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[20];
        int i, countEven = 0, countOdd = 0;
        Console.WriteLine("Hello, enter the number of elements in the first array!");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + n + " elements");
        for (i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Hello, enter the number of elements in the second array!");
        int m = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            b[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Merged array :");
        for (i = 0; i < n; i++)
        {
            c[i] = a[i];
        }

        for (i = 0; i < m ; i++)
            {
                c[i+n] = b[i];
            }
        for (i = 0; i < m + n; i++)
        {
            Console.WriteLine(c[i]);
        }
    }
}