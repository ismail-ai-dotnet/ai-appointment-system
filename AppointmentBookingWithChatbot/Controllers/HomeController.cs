using AppointmentBookingWithChatbot.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppointmentBookingWithChatbot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
