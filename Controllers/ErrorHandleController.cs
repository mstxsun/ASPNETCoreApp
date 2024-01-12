using Microsoft.AspNetCore.Mvc;

namespace Dotnet6Application.Controllers
{
    public class ErrorHandleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return StatusCode(200);
        }

        [HttpGet]
        public IActionResult TryThrow()
        {
            return StatusCode(200);
        }
    }
}
