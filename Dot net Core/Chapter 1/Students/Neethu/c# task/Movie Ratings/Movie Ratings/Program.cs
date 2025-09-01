internal class Program
{
    private static void Main(string[] args)
    {
        double[] Cinema = new double[5];
        double sum = 0;
        Console.WriteLine("Enter 5 movie ratings");
        for (int i = 0; i < Cinema.Length; i++)
        {
            Cinema[i] = double.Parse(Console.ReadLine());
        }
        double highest = double.MinValue;
        double lowest= double.MaxValue;
        
        for(int i = 0;i < Cinema.Length; i++)
        {
            sum += Cinema[i];

            if(Cinema[i] > highest)
            {
                highest = Cinema[i];
            }
            if(Cinema[i] < lowest)
            {
                lowest = Cinema[i];
            }
        }
        double average=sum/Cinema.Length;
        Console.WriteLine("Average rating for the movie"+average);
        Console.WriteLine("Highest Rating is: "+highest);
        Console.WriteLine("Lowest Rating is: " + lowest);


    }
}