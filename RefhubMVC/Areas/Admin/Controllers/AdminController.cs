using Microsoft.AspNetCore.Mvc;

namespace RefhubMVC.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
