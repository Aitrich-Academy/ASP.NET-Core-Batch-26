internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string myString=Console.ReadLine();
        string reversed = "";
        for(int i=myString.Length-1; i>=0; i--)
        {
            reversed += myString[i];
        }
       
        Console.WriteLine("Reversed string is :" + reversed);
    }
}