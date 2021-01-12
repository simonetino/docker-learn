using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {
    public class HelloWorldController : Controller {
        // GET
        public IActionResult Index() {
            return Ok( "Hello World!" );
        }
    }
}