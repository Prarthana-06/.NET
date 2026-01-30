using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using student_web_api.Models;

namespace student_web_api.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _settings;
        public HomeController(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }
        public IActionResult Index()
        {
            return Content(
                $"Name of the Application:{_settings.ApplicationName} \n" +
                $"Support: {_settings.SupportEmail}");
        }
    }
}