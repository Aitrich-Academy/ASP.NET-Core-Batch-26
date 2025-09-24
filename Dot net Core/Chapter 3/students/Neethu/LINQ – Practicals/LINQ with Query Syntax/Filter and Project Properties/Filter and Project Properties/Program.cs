using Filter_and_Project_Properties;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student{Name="Alice",Age=17},
            new Student{Name="Jithin",Age =36},
            new Student{Name="Charlie",Age=20},
            new Student { Name = "Diana", Age = 18 },
            new Student { Name = "Ethan", Age = 21 }

        };
        var Adult=(from student in students where student.Age>18 select student.Name).ToList();
        Console.WriteLine("Sudents above 18 years old");
        foreach(var name in Adult)
        {
            Console.WriteLine(name);

        }
    }
}