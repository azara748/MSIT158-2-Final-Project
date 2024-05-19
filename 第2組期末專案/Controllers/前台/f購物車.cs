using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using 第2組期末專案.Models;

namespace 第2組期末專案.Controllers.前台
{
    public class f購物車 : Controller
    {
        public IActionResult Index()
        {
            int id = 2;
            SelectShopContext db = new SelectShopContext();
            var a = db.TCarts.Where(x => x.MemberId == id);
            var b = a.Join(db.TProducts, x => x.ProductId, y => y.ProductId, (x, y) => new { y.ProductPhoto, y.ProductName, y.UnitPrice, y.Stocks, x.Qty, x.CartId });
            ViewBag.b = b;
            return View();
            //https://localhost:7058/f%E8%B3%BC%E7%89%A9%E8%BB%8A/Index
        }
        public IActionResult Delete(int id)
        {
            SelectShopContext db = new SelectShopContext();
            var a = db.TCarts.FirstOrDefault(x => x.CartId == id);
            db.TCarts.Remove(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult 直接購買(int id, int Qty)
        {
            SelectShopContext db = new SelectShopContext();
            var b = db.TCarts.FirstOrDefault(x => x.ProductId == id && x.MemberId == 2);
            if (b != null) b.Qty += Qty;
            {
                TCart c = new TCart();
                c.Qty = Qty;
                c.ProductId = id;
                c.MemberId = 2;
                db.TCarts.Add(c);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
