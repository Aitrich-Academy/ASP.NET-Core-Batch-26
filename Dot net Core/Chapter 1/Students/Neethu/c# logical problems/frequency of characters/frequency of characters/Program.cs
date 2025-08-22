internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence");
        string myString=Console.ReadLine();
        string CleanedString = myString.ToLower().Replace(" ", "");
        for(int i = 0; i < CleanedString.Length; i++)
        {
            bool isCounted = false;
            for(int k=0;k<i;k++)
            {
                if (CleanedString[i] == CleanedString[k])
                {
                    isCounted = true;
                    break;
                }
            }
            if(!isCounted)
            {
                int repeat = 0;
                for(int j=0;j<CleanedString.Length;j++)
                {
                    if (CleanedString[j] == CleanedString[i])
                    {
                        repeat++;
                    }
                   
                }
                Console.WriteLine($"Frequency of '{CleanedString[i]}' is: {repeat}");
            }
            
        }
    }
}