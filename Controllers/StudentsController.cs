using Microsoft.AspNetCore.Mvc;
using student_portal.Models;

namespace student_portal.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel)
        {

            return View();
        }
    }
}
