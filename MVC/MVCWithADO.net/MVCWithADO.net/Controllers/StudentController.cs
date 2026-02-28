using Microsoft.AspNetCore.Mvc;
using MVCwithADO.Data;

namespace MVCwithADO.net.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _repo;

        public StudentController(StudentRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var students = _repo.GetAllStudents();
            return View(students);
        }

        public IActionResult Receive()
        {
            var msg = TempData["Message"];
            return Content(msg?.ToString());
        }

        // ✅ NEW ACTION METHOD
        
    }
}