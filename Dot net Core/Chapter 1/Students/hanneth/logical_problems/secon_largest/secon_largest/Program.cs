internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int  temp;
        Console.WriteLine("Hello, enter n!");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + n +" elements");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Sorted array is");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i] > a[j])
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.WriteLine("Second largest element is" + a[1]);
    }
}