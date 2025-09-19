using Microsoft.AspNetCore.Mvc;
using MyControllers.Models;

namespace MyControllers.Controllers
{
    public class HomeController: Controller
    {
        [Route("/")]
        [Route("home")]
        public ContentResult Index()
        {
            // return new ContentResult()
            // {
            //     Content = "Hello From Index!",
            //     ContentType = "text/plain"
            // };
            return Content(
                "<h1>Hello From Index!</h1>",
                "text/html"
            );
        }

        [Route("about")]
        public ContentResult About()
        {
            return new ContentResult()
            {
                Content = "Hello From About!",
                ContentType = "text/plain"
            };
        }


        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };
            return Json(person);
        }

        [Route("file-download")]
        public PhysicalFileResult FileDownload()
        {
            return new PhysicalFileResult(@"/Users/edmond.guo/Downloads/aspnet/Controllers/MyControllers/Files/docs.pdf", "application/pdf");
        }

        [Route("file-download2")]
        public IActionResult FileDownload2()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"/Users/edmond.guo/Downloads/aspnet/Controllers/MyControllers/Files/docs.pdf");
            return new FileContentResult(bytes, "application/pdf");
        }

        [Route("contact/{mobile:regex(^\\d{{10}}$)?}")]
        public ContentResult Contact()
        {
            return new ContentResult()
            {
                Content = "Hello From Contact!",
                ContentType = "text/plain"
            };
        }
    }
}