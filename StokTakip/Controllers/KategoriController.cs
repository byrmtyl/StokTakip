using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokTakip.Models.Entity;
namespace StokTakip.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        // GET: Kategori
        StokTakipDBEntities db = new StokTakipDBEntities();
        public ActionResult Index()
        {
            var kategorilst = db.Kategori.ToList();
            return View(kategorilst);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kategori p)
        {
            db.Kategori.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var guncelle = db.Kategori.Find(id);
            return View("Guncelle",guncelle);
        }
        [HttpPost]
        public ActionResult Guncelle(Kategori p)
        {
            var guncelle = db.Kategori.Find(p.Id);
            guncelle.Ad = p.Ad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        

        public ActionResult Sil(int id)
        {
            var sil = db.Kategori.Find(id);
            db.Kategori.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}