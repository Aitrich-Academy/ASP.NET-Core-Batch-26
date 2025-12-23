using Crud_MVC.Models;

namespace Crud_MVC.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void AddStudent(Student student);
        public Student GetStudentById(int id);
        public void UpdateStudent(Student student);
        public void DeleteStudent(int id);
    }
}
