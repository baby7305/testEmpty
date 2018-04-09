using System;
using Microsoft.AspNetCore.Mvc;
using testEmpty.Model;

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

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}