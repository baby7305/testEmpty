using System;
using Microsoft.AspNetCore.Mvc;

namespace testEmpty.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewData["Greeting"] = hour < 12 ? "Good Moring" : "Good Afternoon";
            return View();
        }

        public IActionResult RsvpForm()
        {
            return View();
        }
    }
}