using Microsoft.AspNetCore.Mvc;

namespace Student_web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
