internal class Program
{
    private static void Main(string[] args)
    {
        int[] scores = new int[5];
        Console.WriteLine("Enter the scores got in 5 matches");
        for(int i = 0; i < scores.Length; i++)
        {
            scores[i] = Convert.ToInt32(Console.ReadLine());

        }
        double sum = 0;
        int maxruns = int.MinValue;
        int match = -1;
        for(int i = 0;i < scores.Length; i++)
        {
            sum += scores[i];
            if(scores[i] > maxruns)
            {
                maxruns = scores[i];
                match = i+1;
            }
        }
        double average=sum/scores.Length;
        Console.WriteLine("Total runs scored: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Maximum runs scored: " + maxruns+" in the match "+match);

    }
}