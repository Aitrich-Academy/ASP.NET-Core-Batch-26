internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int i, countEven=0, countOdd=0;
        Console.WriteLine("Hello, enter the number of elements in the array!");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + n + " elements");
        for (i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n;i++)
        {
            if (a[i] % 2 == 0 && a[i]!=0)
            {
                countEven++;
            }
            else if (a[i] == 0)
            {
                continue;
            }
            else
            {
                countOdd++;
            }
        }
        Console.WriteLine("Number of even numbers in the array is" +countEven);
        Console.WriteLine("Number of odd numbers in the array is" +countOdd);

    }
}