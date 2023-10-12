using Microsoft.AspNetCore.Mvc;

namespace DOTNET_Core_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
