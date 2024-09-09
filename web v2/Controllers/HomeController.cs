using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_v2.Models;
using SquareCalculator; // Thêm không gian tên c?a DLL

namespace web_v2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Calculator _calculator;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _calculator = new Calculator(); // Kh?i t?o ??i t??ng Calculator t? DLL
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Thêm ph??ng th?c ?? tính bình ph??ng và hi?n th? k?t qu?
        [HttpPost]
        public IActionResult CalculateSquare(double number)
        {
            double result = _calculator.CalculateSquare(number);
            ViewData["Result"] = result;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
