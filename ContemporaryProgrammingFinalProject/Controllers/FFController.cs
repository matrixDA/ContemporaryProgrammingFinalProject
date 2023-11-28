using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    public class FFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
