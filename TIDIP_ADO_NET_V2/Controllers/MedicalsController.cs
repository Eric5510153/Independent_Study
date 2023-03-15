using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TIDIP_ADO_NET_V2.Models;

namespace TIDIP_ADO_NET_V2.Controllers
{
    public class MedicalsController : Controller
    {
        private TIDIP_V2Entities2 db = new TIDIP_V2Entities2();

        // GET: Medicals
        public ActionResult Index()
        {
            return View(db.Medicals.ToList());
        }

        // GET: Medicals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicals medicals = db.Medicals.Find(id);
            if (medicals == null)
            {
                return HttpNotFound();
            }
            return View(medicals);
        }

        // GET: Medicals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medicals/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MedicalID,MedicalName,County_City,Area,MedicalAddress,MedicalCreatedDate,MedicalTel")] Medicals medicals)
        {
            if (ModelState.IsValid)
            {
                db.Medicals.Add(medicals);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicals);
        }

        // GET: Medicals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicals medicals = db.Medicals.Find(id);
            if (medicals == null)
            {
                return HttpNotFound();
            }
            return View(medicals);
        }

        // POST: Medicals/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MedicalID,MedicalName,County_City,Area,MedicalAddress,MedicalCreatedDate,MedicalTel")] Medicals medicals)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicals).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicals);
        }

        // GET: Medicals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicals medicals = db.Medicals.Find(id);
            if (medicals == null)
            {
                return HttpNotFound();
            }
            return View(medicals);
        }

        // POST: Medicals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Medicals medicals = db.Medicals.Find(id);
            db.Medicals.Remove(medicals);
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
