using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WA.Data;
using WA.Models;

namespace WA.Controllers
{
    public class HomeController : Controller
    {
        private OrderDbContext db = new OrderDbContext(new DbContextOptions<OrderDbContext>());
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("home/new")]
        public IActionResult New()
        {
            //return "I'm new";
            return View();
        }
        
        [Route("home/neworder")]
        public string NewOrder(string? Adress, string? Person)
        {
            return "Thanks for the order, " + Person + ", we sent all information to " + Adress;
        }        
        
        
        [Route("home/postfeedback")]
        public string PostFeedback(string? Adress, string? Person, string? Feedback)
        {
            return $"Hello, + {Person}!" + "Thanks for your feedback.";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}