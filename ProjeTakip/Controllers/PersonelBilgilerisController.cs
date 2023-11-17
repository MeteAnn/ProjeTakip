using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjeTakip.Models.DataContext;
using ProjeTakip.Models.Personel;

namespace ProjeTakip.Controllers
{
    public class PersonelBilgilerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();  //Burada veritabanını çağır diyoruz yani bu veritabanı bağlantısıdır.



        // GET: PersonelBilgileris
        public ActionResult Index() //Verileri listeler
        {
            return View(db.PersonelBilgileris.ToList());
        }





        // GET: PersonelBilgileris/Details/5
        public ActionResult Details(int? id) //id adında bir null integer parametresi alır. int? kullanılmış olması id parametresinin null yani boş bırakılabilir olduğunu gösterir. yani eğer id sağlanmazsa veya null ise bu durumla başa çıkmak için kullanılır.
        {
            if (id == null) //id parametresinin null olup olmadığını kontrol eder. 
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); //Eğer id null ise HTTP 400 Bad Request durum koduyla bir hata döndürülür.
            }

            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id); //Bu satır veritabanından belirli bir id değerine sahip PersonelBilgileri kaydını bulur.

            if (personelBilgileri == null) //Bu kısım, belirli bir id değerine sahip kaydın veritabanında bulunup bulunmadığını kontrol eder.
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        
        public ActionResult Create() //Get işleminde sadece view döndürür.
        {
            return View();
        }

      
        [HttpPost] //Yazdırdığımız verilerin girdiğimiz verilerin veritabanında görünmesini sağlayan kısım post işlemidir.
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.PersonelBilgileris.Add(personelBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // POST: PersonelBilgileris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonelBilgileriId,Eposta,Sifre,Yetki,AdSoyad,TCNO,Departman,Gorev,PozisyonAciklama,TelNo,Adres,MedeniHal,YakinBilgisi,YakinTC,YakinAdSoyad,YakinTel,DogumTarihi,IseGirisTarihi")] PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // POST: PersonelBilgileris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            db.PersonelBilgileris.Remove(personelBilgileri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
