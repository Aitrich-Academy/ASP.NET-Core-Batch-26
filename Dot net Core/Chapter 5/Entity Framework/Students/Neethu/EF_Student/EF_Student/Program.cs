using EF_Student.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new CfaContext())
        {
            var newstudent = new Student { Sname = "Jayasree", Smark = 70 };
            context.Students.Add(newstudent);
            context.SaveChanges();
            Console.WriteLine("New student got added");

            var students=context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.StudentId}--Name: {student.Sname}--Mark: {student.Smark}");
            }
        }


    }
}