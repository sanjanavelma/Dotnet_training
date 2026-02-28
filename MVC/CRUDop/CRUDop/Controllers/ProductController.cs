using Microsoft.AspNetCore.Mvc;

namespace CRUDop.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
