using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
