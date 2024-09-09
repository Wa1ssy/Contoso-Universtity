using Microsoft.AspNetCore.Mvc;

namespace ContosoUniverstity.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
