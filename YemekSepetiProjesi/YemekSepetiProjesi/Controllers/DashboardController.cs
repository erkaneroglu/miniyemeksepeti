using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepetiProjesi.Models.Entity;

namespace YemekSepetiProjesi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        YemekSepetiDBEntities db = new YemekSepetiDBEntities();
        public ActionResult Index()
        {
            return View();
        }
	}
}