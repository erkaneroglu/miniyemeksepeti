using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;


namespace YemekSepetiProjesi.Controllers
{
    [Authorize]
    public class AnaSayfaController : Controller
    {
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();

        public ActionResult Index()
        {
            var yemekler = db.TBLYemekler.ToList();
            return View(yemekler);
        }
        public ActionResult SikSorulanSorular()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult KullaniciSozlesmesi()
        {
            return View();
        }

        public ActionResult DetailPage(int id)
        {
            var yemekler = db.TBLYemekler.Find(id);
            return View("DetailPage", yemekler);
        }
	}
}