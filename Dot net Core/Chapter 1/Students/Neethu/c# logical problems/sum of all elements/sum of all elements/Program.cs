internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 numbers!");
        double[] numbers=new double[5];
        double sum = 0;
        for(int i=0;i<5;i++)
        {
            numbers[i]=Convert.ToDouble(Console.ReadLine());
            sum+=numbers[i];
        }
        Console.WriteLine("Sum of Array is:" +sum);
        

    }
}