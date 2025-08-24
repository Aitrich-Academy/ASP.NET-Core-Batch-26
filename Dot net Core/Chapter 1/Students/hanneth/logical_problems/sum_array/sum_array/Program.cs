internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int i, sum = 0 ;
        Console.WriteLine("Hello, enter the number of elements in the array!");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter " + n + " elements");
        for (i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n; i++)
        {
            sum += a[i];
        }
        Console.WriteLine("Sum of elements in the array is" +sum);
    }
}