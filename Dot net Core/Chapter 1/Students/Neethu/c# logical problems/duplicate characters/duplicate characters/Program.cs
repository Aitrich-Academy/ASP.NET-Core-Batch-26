internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string!");
        string myString=Console.ReadLine();
        string cleanedString = myString.ToLower().Replace(" ", "");
        string result = " " ;
        for(int i=0; i<cleanedString.Length; i++)
        {
            char currentChar = cleanedString[i];
            bool isDuplicate=false;
            for( int j = 0;j < result.Length;j++)
            {
                if(result[j] == currentChar)
                {
                    isDuplicate = true;
                    break;
                }

            }
            if(!isDuplicate)
            {
                result += currentChar;
            }
        }
        Console.WriteLine("String without Duplicate Characters is:" + result);
    }
}