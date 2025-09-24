internal class Program
{
    private static void Main(string[] args)
    {
        List<int> productId=new List<int> { 001,002,003,004,005,006,007,008};
        var Id = productId.Single(n => n == 005);
        Console.WriteLine($"Matching id found: {Id}");
        var nonmatchId = productId.SingleOrDefault(n => n == 200);
        if(nonmatchId == 0)
        {
            Console.WriteLine("Id you are searching is not found");

        }
        else
        {
            Console.WriteLine($"Id found is:{nonmatchId}");
        }



   }
}