internal class Program
{
    private static void Main(string[] args)
    {
       List<string> students= new List<string> { "Neethu", "Anna","John","Ashmi","Alia"};
        Console.WriteLine("Sorted names by method");
        var alphabetNames = students.Where(n => n.StartsWith("A")).OrderBy(n => n);
        foreach (var name in alphabetNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("Sorted names by Query");
        var sortednames=from student in students where student.StartsWith("A") orderby student select student;
        foreach (var name in sortednames)
        {
            Console.WriteLine(name);
        }



    }
}