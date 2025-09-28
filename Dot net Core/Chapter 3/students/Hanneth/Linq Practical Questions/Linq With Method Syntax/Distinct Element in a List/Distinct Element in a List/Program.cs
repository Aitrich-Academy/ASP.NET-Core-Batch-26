internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers=new List<int> { 1,2,3,2,4,3,5,3,6,4,7,6,8,4,9,10};
       IEnumerable<int> DistinctNumbers=numbers.Distinct();
       foreach(int i in DistinctNumbers)
        {
            Console.WriteLine(i);
        }

    }
}