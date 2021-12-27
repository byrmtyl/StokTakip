using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using StokTakip.Models.Entity;

namespace StokTakip.Controllers
{
    public class LoginController : Controller
    {
        StokTakipDBEntities db = new StokTakipDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Admin a)
        {


            var bilgiler = db.Admin.FirstOrDefault(m => m.KullaniciAdi.Equals(a.KullaniciAdi) && m.Sifre.Equals(a.Sifre));
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi,false);
                Session["Admin"] = bilgiler.Ad.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya şifre hatalı...!";
                return View();
            }
           
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }


    }
}