using Microsoft.AspNetCore.Mvc;

namespace Web.Area.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
