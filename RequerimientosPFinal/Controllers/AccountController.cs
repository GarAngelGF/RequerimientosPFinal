using Microsoft.AspNetCore.Mvc;

namespace RequerimientosPFinal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
