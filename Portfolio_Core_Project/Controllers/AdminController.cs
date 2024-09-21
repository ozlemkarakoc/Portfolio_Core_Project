using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core_Project.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
