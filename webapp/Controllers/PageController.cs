using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult NotAdmin()
        {
            return View();
        }
    }
}
