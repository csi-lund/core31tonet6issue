using Microsoft.AspNetCore.Mvc;

namespace rerun31
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return NotFound();
        }
    }
}
