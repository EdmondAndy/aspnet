using Microsoft.AspNetCore.Mvc;

namespace MyCitiesManager.Controllers
{
 [Route("api/v{version:apiVersion}/[controller]")]
 [ApiController]
 public class CustomControllerBase : ControllerBase
 {
 }
}