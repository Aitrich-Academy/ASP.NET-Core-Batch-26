using Crud_MVC.Models;
using Crud_MVC.Repositories;

namespace Crud_MVC.Services
{
    public class StudentService:IStudentServicecs
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }

        public List<Student> GetAllStudents()
        {
            return repo.GetAllStudents();
        }
        public void AddStudent(Student student)
        {
            repo.AddStudent(student);
        }
        public Student GetStudentById(int id)=>repo.GetStudentById(id);
        public void UpdateStudent(Student student)=>repo.UpdateStudent(student);
        public void DeleteStudent(int id)=>repo.DeleteStudent(id);
    }
}
