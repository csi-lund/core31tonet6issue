using Microsoft.AspNetCore.Mvc;

namespace rerun
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return NotFound();
        }
    }
}
