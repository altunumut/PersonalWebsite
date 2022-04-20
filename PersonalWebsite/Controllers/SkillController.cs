using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
