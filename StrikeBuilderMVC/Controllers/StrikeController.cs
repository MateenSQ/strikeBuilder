using Microsoft.AspNetCore.Mvc;

namespace StrikeBuilderMVC.Controllers
{
    public class StrikeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
