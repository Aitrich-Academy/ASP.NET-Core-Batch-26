internal class Program
{
    private static void Main(string[] args)
    {
        int i,j;
        int[] a = new int[10];
        Console.WriteLine("Hello, enter the number of elements in the array");
        int n =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + n + " numbers");
        for(i=0;i<n;i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n; i++)
        {
                if (a[i] == a[i+1])
                {                 
                    Console.WriteLine("duplicates are" + a[i]);
                }
            }
        }
    }
}