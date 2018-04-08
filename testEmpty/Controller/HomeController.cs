using Microsoft.AspNetCore.Mvc;

namespace testEmpty.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}