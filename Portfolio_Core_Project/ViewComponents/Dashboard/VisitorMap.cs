using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core_Project.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
