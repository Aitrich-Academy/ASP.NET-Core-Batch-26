internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
        //Get only short words
        var shortwords = words.Where(word =>word.Length <=5);
        //Print each word out
        foreach (var word in shortwords)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }

}
