using Microsoft.AspNetCore.Mvc;

namespace FinalProjects.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
