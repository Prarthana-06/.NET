using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using studentWebAPI.Models;

namespace studentWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSetting _Setting; //dependeance injection
        public HomeController(IOptions<AppSetting> setting)
        {
          _Setting = setting.Value;
        }
        public IActionResult Index()
        {
            return Content( 
                $"Name of the Application:{_Setting.ApplicationName}\n"+
              $"Support :{_Setting.SupportEmail}");
        }
    }
}
