using Microsoft.AspNetCore.Mvc;

namespace RequerimientosPFinal.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
