using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
