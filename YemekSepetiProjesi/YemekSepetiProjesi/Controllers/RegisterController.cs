using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YemekSepetiProjesi.Models.Entity;

namespace YemekSepetiProjesi.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        //
        // GET: /Register/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBLKullanicilar kullanici)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                kullanici.Rol = "User";
                db.Entry(kullanici).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
	}
}