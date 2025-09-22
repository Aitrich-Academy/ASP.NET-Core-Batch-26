internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int,string> students= new Dictionary<int, string>{ { 1, "John" },{ 2,"Jane"},{ 3,"Doe"}};
        var result = students.Where(n => n.Key > 1);
        foreach(var student in result)
        {
            Console.WriteLine(student);
        }
                
        
    }
}