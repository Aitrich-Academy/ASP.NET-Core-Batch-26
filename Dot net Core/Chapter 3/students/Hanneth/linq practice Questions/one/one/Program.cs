using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> studentNames = new List<string> { "Hanna","Asad","Pathu","Affan","Aboo"};
        var students = studentNames.Where(s => s.StartsWith("A"));
        foreach (var student in students) { Console.WriteLine(student); }
        Console.WriteLine();
        var stud=from s in students where s.StartsWith("A") select s;
        foreach(var student in stud) { Console.WriteLine( student ); }


    }
}