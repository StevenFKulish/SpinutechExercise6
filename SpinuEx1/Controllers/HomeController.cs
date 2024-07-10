using Microsoft.AspNetCore.Mvc;
using SpinuEx1.Models;
using System.Diagnostics;
using SpinuEx1.Services.Interfaces;

namespace SpinuEx1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPalindromeService _palindromeService;

        public HomeController(ILogger<HomeController> logger, 
                              IPalindromeService palindromeService)
        {
            _logger = logger;
            _palindromeService = palindromeService;
        }

        public IActionResult Index()
        {
            PalindromeTest model = new PalindromeTest();

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(PalindromeTest model)
        {
            if (model.InputNumeric == null)
                model.InputNumeric = "";

            //process the value 
            if (_palindromeService.PalindromeDataCheck(model))
            {
                model.Result = _palindromeService.PalindromeCalculator(int.Parse(model.InputNumeric));
            }

            return View(model);
        }

        public IActionResult Privacy()
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
