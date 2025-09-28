internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers= new List<int> { 50,56,34,76,12,50,32,43,67};
        var result=numbers.Where(num => num > 50).ToList();
        var res=result.OrderByDescending(x => x).ToList();
        foreach(int nu in res) {Console.WriteLine(nu); }
    }
}