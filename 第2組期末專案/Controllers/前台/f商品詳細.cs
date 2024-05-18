using Microsoft.AspNetCore.Mvc;
using 第2組期末專案.Models;

namespace 第2組期末專案.Controllers.前台
{
    public class f商品詳細 : Controller
    {
        public IActionResult Index()
        {
            Random r = new Random();
            int id= r.Next(1,200);
			SelectShopContext db = new SelectShopContext();
            TProduct a = null;
            while (a == null)
            { 
                a = db.TProducts.FirstOrDefault(x => x.ProductId == id);
                id = r.Next(1, 200);
            }
            var b = db.TReviews.Join(db.TMembers, x => x.MemberId, y => y.MemberId, (x, y) =>
            new { x.ReviewDate, x.RankId, x.Comment,y.MemberName});
           ViewBag.b = b;
            return View(a);
		}      
    }
}

