using MyOrderApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyOrderApp.Controllers
{
    public class OrderController : Controller
    {
        //When request is received at path "/order"
        [Route("/order")]
        //bind only the desired properties of Order class, i.e. 'OrderDate', "InvoicePrice" and "Products"
        public IActionResult Index([Bind(nameof(Order.OrderDate), nameof(Order.InvoicePrice), nameof(Order.Products))] Order order)
        {
            // if there are any validation errors (as per data annotations)
            if (!ModelState.IsValid)
            {
                string messages = string.Join("\n", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return BadRequest(messages);
            }

            Random random = new Random();
            int randomOrderNumber = random.Next(1, 99999);

            //return HTTP 200 response with order number
            return Json(new { OrderNumber = randomOrderNumber });
        }
    }
}