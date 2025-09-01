internal class Program
{
    private static void Main(string[] args)
    {
        int[] Sales = new int[7];
        Console.WriteLine("Enter the sales for the week");
        int day = -1;
        double sum = 0;
        for(int i = 0; i < Sales.Length; i++)
        {
            Sales[i] = Convert.ToInt32(Console.ReadLine());

        }
        int maxsale = int.MinValue;
        for(int i = 0;i < Sales.Length;i++)
        {
            sum+= Sales[i];
            if(Sales[i] > maxsale)
            {
                maxsale = Sales[i];
                day = i+1;
            }
        }
        double average=sum/Sales.Length;
        Console.WriteLine("Total :"+sum);
        Console.WriteLine("Average sales :" + average);
        Console.WriteLine("Day with maximum sales :" + day+" ,"+maxsale);


    }
}