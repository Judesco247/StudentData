using Microsoft.AspNetCore.Mvc;

namespace StudentData.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult StatesUpdates()
        {
            return View();
        }
    }
}
