using ASPDotNetCoreMVC_MSSQL_EF_Template.Models;
using ASPDotNetCoreMVC_MSSQL_EF_Template.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreMVC_MSSQL_EF_Template.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository<Student> Student;

        public StudentController(IRepository<Student> student)
        {
            Student = student;
        }

        public async Task<IActionResult> Index()
        {
            var students = await Student.GetStudents();
            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student data)
        {
            if(ModelState.IsValid)
            {
                await Student.Add(data);
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
