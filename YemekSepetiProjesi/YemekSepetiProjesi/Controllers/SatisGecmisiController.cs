using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;


namespace YemekSepetiProjesi.Controllers
{
   [Authorize(Roles = "Admin")]
    public class SatisGecmisiController : Controller
    {
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        //
        // GET: /SatisGecmisi/
        public ActionResult Index()
        {
            var satislar = db.TBLSatislar.ToList();
            return View(satislar);
        }
	}
}