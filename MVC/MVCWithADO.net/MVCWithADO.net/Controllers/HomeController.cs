using Microsoft.AspNetCore.Mvc;
using MVCWithADO.net.Models;
using System.Diagnostics;

namespace MVCWithADO.net.Controllers
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
            ViewBag.Name = "Sanjana Velma";
            ViewData["College"] = "Lovely Professional University";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
