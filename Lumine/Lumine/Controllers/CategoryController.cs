using Microsoft.AspNetCore.Mvc;

namespace LumineWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
