using Microsoft.AspNetCore.Mvc;
using Studentprint.Models;
using System.Diagnostics;

namespace Studentprint.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MyNamePrint()
        {
            ViewBag.x = "Sanjana";
            ViewBag.y = "LPU";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
