using Microsoft.AspNetCore.Mvc;

namespace MyIActionResult.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/books")]
        public IActionResult Books()
        {
            return Content("<h1>Books Page</h1>", "text/html");
        }
    }
}