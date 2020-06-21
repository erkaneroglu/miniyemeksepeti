using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;
using System.Web.Security;

namespace YemekSepetiProjesi.Controllers
{
        [AllowAnonymous]
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBLKullanicilar user)
        {
            var kullanici = db.TBLKullanicilar.FirstOrDefault(c => c.KullaniciAdi == user.KullaniciAdi && c.Sifre == user.Sifre);
            if(kullanici!=null){
                FormsAuthentication.SetAuthCookie(user.KullaniciAdi,false);
                return RedirectToAction("Index","Route");
            }
            ViewBag.hata = "Kullanıcı adı veya şifreniz yanlış!";
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }

	}
}