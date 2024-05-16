using Microsoft.AspNetCore.Mvc;
using 第2組期末專案.Models;

namespace 第2組期末專案.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
//測試用
            return View();

        }
    }

    //測試用Main更新??
}
