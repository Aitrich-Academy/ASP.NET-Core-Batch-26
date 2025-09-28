class Student
{
   public string Name;
   public int Age;
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>()
        {
            new Student{Name ="Hanneth",Age=22 },
            new Student{Name="Aboo",Age=15},
             new Student{Name="Pathu",Age=29},
              new Student{Name="Affan",Age=5},
               new Student{Name="Asad",Age=24},
                new Student{Name="Abs",Age=15},
        };
        var studentgreater18=from l in list where l.Age>18 select l.Name;
        foreach(var student in studentgreater18)
        {
            Console.WriteLine(student);
        }
    }
}