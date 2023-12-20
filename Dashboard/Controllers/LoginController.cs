using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
