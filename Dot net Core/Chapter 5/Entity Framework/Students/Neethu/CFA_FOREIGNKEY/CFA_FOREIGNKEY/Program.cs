using CFA_FOREIGNKEY.Data;
using CFA_FOREIGNKEY.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using(var context=new AppDbContext())
        {

            var newDepartment = new Department { DName = "Maths" };
            context.Departments.Add(newDepartment);
            context.SaveChanges();

            var departments = context.Departments.ToList();
            foreach (var department in departments)
            {
                Console.WriteLine($"Department ID: {department.DId}--DepartmentName: {department.DName}");
            }

            var newInstructor = new Instructor { Name = "Ria", Dept_Id =1};
            context.Instructors.Add(newInstructor);
            context.SaveChanges();

            var instructors=context.Instructors.ToList();
            foreach (var instructor in instructors)
            {
                Console.WriteLine($"InstructorId: {instructor.Id} Name: {instructor.Name} Department: {instructor.Dept_Id}");
            }

        }
    }
}