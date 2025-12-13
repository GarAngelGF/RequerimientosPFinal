using Microsoft.AspNetCore.Mvc;

namespace RequerimientosPFinal.Controllers
{
    public class ActividadesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
