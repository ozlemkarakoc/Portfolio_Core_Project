using Microsoft.AspNetCore.Mvc;
using Portfolio_Core_Project.Areas.Writer.Models;

namespace Portfolio_Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserRegisterViewModel p)
        {
            if(ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}
