using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;

namespace YemekSepetiProjesi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MusterilerController : Controller
    {
        //
        // GET: /Musteriler/
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        public ActionResult Index(string n)
        {
            var degerler = from d in db.TBLMusteriler select d;
            if (!string.IsNullOrEmpty(n))
            {
                degerler = degerler.Where(m => m.MusteriAdi.Contains(n));
            }
            return View(degerler.ToList());
            //var degerler = db.TBLMusteriler.ToList();
            //return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMusteri(TBLMusteriler mstr)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");
            }
            db.TBLMusteriler.Add(mstr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var musteri = db.TBLMusteriler.Find(id);
            db.TBLMusteriler.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mus = db.TBLMusteriler.Find(id);
            return View("MusteriGetir", mus);
        }

        public ActionResult Guncelle(TBLMusteriler mst)
        {
            var musteri = db.TBLMusteriler.Find(mst.MusteriId);
            musteri.MusteriAdi = mst.MusteriAdi;
            musteri.MusteriSoyad = mst.MusteriSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}