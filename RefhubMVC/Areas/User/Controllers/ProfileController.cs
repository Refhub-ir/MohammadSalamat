using Microsoft.AspNetCore.Mvc;

namespace RefhubMVC.Areas.User.Controllers
{
    [Area("User")]

    public class ProfileController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
