using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginOTP()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult PasswordRecovery()
        {
            return View();
        }

        public ActionResult ItemDetailMaintenance()
        {
            return View();
        }

        public ActionResult FormAlert()
        {
            return View();
        }
	}
}