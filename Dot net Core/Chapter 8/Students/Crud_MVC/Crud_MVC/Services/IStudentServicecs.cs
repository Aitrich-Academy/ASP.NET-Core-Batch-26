using Crud_MVC.Models;

namespace Crud_MVC.Services
{
    public interface IStudentServicecs
    {
        public List<Student> GetAllStudents();
        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        public Student GetStudentById(int id);
        public void DeleteStudent(int id);

    }
}
