using System.Security.Cryptography;

namespace 第2組期末專案.Models.前台
{
    public class f購物車
    {
        public void add購物車(TCart a)
        {
            SelectShopContext db = new SelectShopContext();
            var b = db.TCarts.FirstOrDefault(x => x.ProductId == a.ProductId);
            if (b == null) db.Add(a);
            else b.Qty += a.Qty;
            db.SaveChanges();
        }
        public void plus購物車(int id ,int mid)
        {
            SelectShopContext db = new SelectShopContext();
            var a =db.TCarts.FirstOrDefault(x => x.ProductId == id && x.MemberId == mid);
            a.Qty++;
            db.SaveChanges(); 
        }
        public void minus購物車(int id, int mid)
        {
            SelectShopContext db = new SelectShopContext();
            var a = db.TCarts.FirstOrDefault(x => x.ProductId == id && x.MemberId == mid);
            a.Qty--;
            db.SaveChanges(); 
        }
        public void delete購物車(int id, int mid)
        {
            SelectShopContext db = new SelectShopContext();
            var a = db.TCarts.FirstOrDefault(x => x.ProductId == id && x.MemberId == mid);
            db.Remove(a);
            db.SaveChanges();
        }
    }
}
