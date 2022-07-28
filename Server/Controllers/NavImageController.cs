using Microsoft.AspNetCore.Mvc;

namespace BroadmountainLive.Server.Controllers
{
    public class NavImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
