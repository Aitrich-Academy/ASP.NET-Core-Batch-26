internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms for fibonacci series");
        int n=Convert.ToInt32(Console.ReadLine());
        int first = 0 , second = 1 , next ;
        Console.WriteLine("Fibonacci series:");
        for (int i = 0 ; i < n ; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
    }
}