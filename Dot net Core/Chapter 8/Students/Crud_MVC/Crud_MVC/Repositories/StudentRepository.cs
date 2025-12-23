using Crud_MVC.Data;
using Crud_MVC.Models;

namespace Crud_MVC.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;
        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }
        public void AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public Student GetStudentById(int id) => context.Students.Find(id);
        public void UpdateStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var student=context.Students.Find(id);
            if(student!=null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }


    }
}
