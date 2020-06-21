using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;

namespace YemekSepetiProjesi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SatisController : Controller
    {
        //
        // GET: /Satis/
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            //List<SelectListItem> degerler = (from i in db.TBLYemekler.ToList()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = i.YemekAdi,
            //                                     Value = i.YemekID.ToString()
            //                                 }).ToList();
            //ViewBag.dgr = degerler;

            //List<SelectListItem> degerleriki = (from i in db.TBLMusteriler.ToList()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = i.MusteriAdi,
            //                                     Value = i.MusteriId.ToString()
            //                                 }).ToList();
            //ViewBag.dgrr = degerleriki;
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(TBLSatislar satislar)
        {
            //var must = db.TBLMusteriler.Where(m => m.MusteriId == musteri.MusteriId).FirstOrDefault();
            //satislar.TBLMusteriler = must;

            //var yemekler = db.TBLYemekler.Where(m => m.YemekID== yemek.YemekID).FirstOrDefault();
            //satislar.TBLYemekler = yemekler;

            ////musteriId - satisId


            ////db.TBLYemekler.Add(yemek);
            ////db.SaveChanges();
            ////return RedirectToAction("Index");


            db.TBLSatislar.Add(satislar);
            db.SaveChanges();
            return View("Index");
        }
	}
}