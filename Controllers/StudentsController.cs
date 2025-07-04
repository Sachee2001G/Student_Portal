using Microsoft.AspNetCore.Mvc;

namespace student_portal.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
