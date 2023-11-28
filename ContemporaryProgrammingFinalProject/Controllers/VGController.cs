using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    public class VGController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
