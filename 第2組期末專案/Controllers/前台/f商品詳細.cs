using Microsoft.AspNetCore.Mvc;
using 第2組期末專案.Models;

namespace 第2組期末專案.Controllers.前台
{
    public class f商品詳細 : Controller
    {
        public IActionResult Index()
        {
            Random r = new Random();
            int id = r.Next(1, 200);
            SelectShopContext db = new SelectShopContext();
            TProduct a = null;
            while (a == null)
            {
                a = db.TProducts.FirstOrDefault(x => x.ProductId == id);
                id = r.Next(1, 200);
            }
            var b = db.TReviews.Join(db.TMembers, x => x.MemberId, y => y.MemberId, (x, y) =>
            new { x.ReviewDate, x.RankId, x.Comment, y.MemberName });
            ViewBag.b = b;
            var c = db.TLabels.FirstOrDefault(x => x.LabelId == a.LabelId);
            ViewBag.c = c;
            return View(a);
        }
        [HttpPost]
        public IActionResult Index(TCart c)
        {
            SelectShopContext db = new SelectShopContext();
            var b = db.TCarts.FirstOrDefault(x => x.ProductId == c.ProductId&&x.MemberId==2);
            if (b != null) b.Qty += c.Qty;
            else
            {
            c.MemberId = 2;
            db.TCarts.Add(c); 
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

