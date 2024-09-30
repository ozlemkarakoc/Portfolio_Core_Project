using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core_Project.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
