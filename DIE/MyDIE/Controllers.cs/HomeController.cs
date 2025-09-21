using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace MyDIE.Controllers
{ 
    public class HomeController : Controller
    {
        private readonly ICitiesService _citiesService;

        //constructor
        public HomeController(ICitiesService citiesService)
        {
            _citiesService = citiesService; //Dependency Injection
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}