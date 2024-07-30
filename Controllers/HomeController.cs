using Microsoft.AspNetCore.Mvc;
using SanlamDemo.Models;
using System.Collections;
using System.Diagnostics;

namespace SanlamDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public int logged = 0;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Username = "Username skmfal";
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String Email)
        {
            ViewBag.Username = Email;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FinancialPlanning()
        {
            return View();
        }
        public IActionResult Health()
        {
            IDictionary<int,String> MonthPairs= new Dictionary<int,String>();  
            string[] months=new string[12] { "January","Febuary","March","April","May","June","July","August","September","October","November","December"};
            
            for(int i = 1; i <= 12; i++)
            {
                MonthPairs.Add(i, months[i-1]);
            }

            DateTime current = DateTime.Now;
            

            ViewBag.Month=MonthPairs[current.Month];
            ViewBag.Day=current.Day;
            return View();
        }
        public IActionResult Insurance()
        {
            return View();
        }
        public IActionResult Investments()
        {
            return View();
        }
        public IActionResult Wealth()
        {
            return View();
        }
        public IActionResult Retirement()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}