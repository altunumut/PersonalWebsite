using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.DashBoard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
