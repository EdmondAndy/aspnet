using Microsoft.AspNetCore.Mvc;     
using MyViews.Models;

namespace MyViews.Controllers
{
    public class HomeController : Controller
    {
        [Route("/home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "Asp.Net Core MVC Application";
            Person person = new Person
            {
                Name = "Edmond",
                DateOfBirth = new DateTime(1990, 1, 1)
            };
            ViewData["person"] = person;
            return View();
        }
    }
}