internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string myString=Console.ReadLine();
        myString = myString.ToLower().Replace(" ","");
        string originalString=myString;

        char[] newArray = myString.ToCharArray();
        Array.Reverse( newArray );
        string reversed = new string(newArray);
       
        
        if(originalString==reversed)
        {
            Console.WriteLine("String is Palindrome");
        }
        else
        {
            Console.WriteLine("String is not palindrome");
        }
    }
}