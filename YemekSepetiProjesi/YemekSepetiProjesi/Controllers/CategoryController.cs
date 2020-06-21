using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace YemekSepetiProjesi.Controllers
{
    [Authorize(Roles="Admin")]
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        public ActionResult Index(int sayfa=1)
        {
            var degerler = db.TBLKategoriler.ToList().ToPagedList(sayfa,5);
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TBLKategoriler ctg)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.TBLKategoriler.Add(ctg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var kategori = db.TBLKategoriler.Find(id);
            db.TBLKategoriler.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var ktg = db.TBLKategoriler.Find(id);
            return View("KategoriGetir", ktg);
        }

        public ActionResult Guncelle(TBLKategoriler ktg)
        {
            var kategoriler = db.TBLKategoriler.Find(ktg.KategoriId);
            kategoriler.KategoriAdi = ktg.KategoriAdi;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}