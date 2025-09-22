using Microsoft.AspNetCore.Mvc;

namespace MyConfigurations.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/")]
        public IActionResult Index()
        {
            //ViewBag.MyKey = _configuration["Mykey"]; 

            // var myValue = _configuration["weatherapi:ClientSecret"];
            // ViewBag.MyValue = myValue;
            // ViewBag.MyKey = _configuration["weatherapi:ClientID"];

            // IConfigurationSection weatherapiSection = _configuration.GetSection("weatherapi");

            // ViewBag.MyKey = weatherapiSection["ClientID"];
            // ViewBag.MyValue = weatherapiSection["ClientSecret"];

            WeatherApiOptions? weatherapiOptions = _configuration.GetSection("weatherapi").Get<WeatherApiOptions>();

            ViewBag.MyKey = weatherapiOptions?.ClientID;
            ViewBag.MyValue = weatherapiOptions?.ClientSecret;            

            return View();
        }
    }
}