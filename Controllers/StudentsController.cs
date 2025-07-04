using Microsoft.AspNetCore.Mvc;

namespace student_portal.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
