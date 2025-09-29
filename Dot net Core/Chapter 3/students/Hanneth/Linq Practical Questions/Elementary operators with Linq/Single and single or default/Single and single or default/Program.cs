internal class Program
{
    private static void Main(string[] args)
    {
       List<string> productID = new List<string> { "123"};
       var singleList = productID.Single();
      Console.WriteLine("Single List : " + singleList);
        var singleorDefault=productID.SingleOrDefault();
        Console.WriteLine("Single or default : " +singleorDefault);
    }
}