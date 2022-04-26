using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
