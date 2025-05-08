using Microsoft.AspNetCore.Mvc;

namespace RefhubMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
