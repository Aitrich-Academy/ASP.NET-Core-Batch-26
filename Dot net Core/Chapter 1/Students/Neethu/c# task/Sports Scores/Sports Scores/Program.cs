using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] scores=new int[6];
        int highest = int.MinValue;
        double sum = 0;
        int matchnumber = -1;
        Console.WriteLine("Enter Scores for 6 matches");
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0;i < scores.Length; i++)
        {
            sum += scores[i];

            if(scores[i] > highest)
            {
                highest = scores[i];
                matchnumber = i+1;
            }
        }
        double average=sum/scores.Length;
        Console.WriteLine("Total score: " + sum);
        Console.WriteLine("Average score: " + average);
        Console.WriteLine("match number with the highest score: " + matchnumber + "," + highest);


    }
}