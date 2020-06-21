using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;

namespace YemekSepetiProjesi.Controllers
{
   [Authorize(Roles = "Admin")]
    public class UrunlerController : Controller
    {
        //
        // GET: /Urunler/
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLYemekler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler = (from i in db.TBLKategoriler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriAdi,
                                                 Value = i.KategoriId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult YeniUrun(TBLYemekler yemek)
        {
            var ktg = db.TBLKategoriler.Where(m=> m.KategoriId == yemek.TBLKategoriler.KategoriId).FirstOrDefault();
            yemek.TBLKategoriler = ktg;

            db.TBLYemekler.Add(yemek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var urun = db.TBLYemekler.Find(id);
            db.TBLYemekler.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGetir(int id)
        {
            var yemek = db.TBLYemekler.Find(id);
            List<SelectListItem> degerler = (from i in db.TBLKategoriler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriAdi,
                                                 Value = i.KategoriId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View("UrunGetir", yemek);
        }

        public ActionResult Guncelle(TBLYemekler yemekler) 
        {
            var ymk = db.TBLYemekler.Find(yemekler.YemekID);
            ymk.YemekAdi = yemekler.YemekAdi;
            ymk.YemekFiyat = yemekler.YemekFiyat;
            ymk.Stok = yemekler.Stok;
            var ktg = db.TBLKategoriler.Where(m => m.KategoriId == yemekler.TBLKategoriler.KategoriId).FirstOrDefault();
            ymk.YemekKategori = ktg.KategoriId;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}