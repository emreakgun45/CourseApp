using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }


        //localhost:5000/course/apply method:POST
        // Name= value&Email=value&Phone=value&Confirm=value

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudents(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }

        }


        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core MVC Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;
            return View(course);
        }


        public IActionResult List()
        {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
        }
    }
}
