using Microsoft.AspNetCore.Mvc;

namespace 第2組期末專案.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
