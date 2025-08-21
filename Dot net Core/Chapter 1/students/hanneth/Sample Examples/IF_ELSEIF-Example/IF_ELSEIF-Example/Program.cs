internal class Program
{
    private static void Main(string[] args)
    {
        int marks = 75;

        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade B");
        }
        else
        {
            Console.WriteLine("Grade C");
        }
    }
}