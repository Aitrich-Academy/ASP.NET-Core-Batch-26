internal class Program
{
    private static void Main(string[] args)
    {
        int[] mark = new int[3];
        string ch;
        long  sum=0;
        long average = 0;
        do {
            sum = 0;
            average = 0;
        Console.WriteLine("Enter the student name");
        string name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the mark " + (i + 1) + "out of 100");
                mark[i] = Convert.ToInt32(Console.ReadLine());
                sum += mark[i];
                average =(sum)/ 3;
            }
                if (average>=90)
                {
                    Console.WriteLine("Average is "+average);
                    Console.WriteLine("Grade A");
                }
                else if(average>=75&&average<90)
                {
                Console.WriteLine("Average is " + average);
                Console.WriteLine("Grade B");
                }
                else if(average>=50&&average<75)
                {
                Console.WriteLine("Average is " + average);
                Console.WriteLine("Grade C");
                }
                else if(average<50)
                {
                Console.WriteLine("Average is " + average);
                Console.WriteLine("Grade F");
                }
        Console.WriteLine("Do you want to continue?(y/n)");
        ch =Console.ReadLine();
    }while(ch=="y");
    }
}