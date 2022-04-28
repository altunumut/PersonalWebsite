using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.DashBoard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
