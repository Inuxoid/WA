using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WA.Data;
using WA.Models;

namespace WA.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderDbContext _db;
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, OrderDbContext db)
        {
            _logger = logger;
            _db = db;
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
        public string NewOrder(string Address, string Person, string Details)
        {
            var Order1 = new OrderModel() {Name = Person, Email = Address, Details = Details };
            _db.Orders.Add(Order1);
            _db.SaveChanges();
            return "Thanks for the order, " + Person + ", we sent all information to " + Address;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}