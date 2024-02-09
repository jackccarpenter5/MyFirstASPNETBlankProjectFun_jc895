using Microsoft.AspNetCore.Mvc;

// This is my HomeController page
namespace MyFirstASPNETBlankProjectFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Package_Calculations()
        {
            return View();
        }
    }
}
