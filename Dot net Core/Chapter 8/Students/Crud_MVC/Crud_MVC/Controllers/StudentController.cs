using Crud_MVC.Models;
using Crud_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServicecs studentService;
        public StudentController(IStudentServicecs studentServicecs)
        {
           studentService = studentServicecs;
        }
        public IActionResult Index()
        {
            var students=studentService.GetAllStudents();
            return View(students);
        }
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(Student student)
        {
            studentService.AddStudent(student);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var student=studentService.GetStudentById(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            studentService.UpdateStudent(student);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var student=studentService.GetStudentById(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }

    }
}
