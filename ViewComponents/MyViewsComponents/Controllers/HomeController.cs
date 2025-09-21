using Microsoft.AspNetCore.Mvc;

namespace MyViewsComponents.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}