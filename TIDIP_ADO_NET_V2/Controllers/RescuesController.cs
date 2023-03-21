using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TIDIP_ADO_NET_V2.Models;

namespace TIDIP_ADO_NET_V2.Controllers
{
    public class RescuesController : Controller
    {
        private TIDIP_V2Entities2 db = new TIDIP_V2Entities2();

        // GET: Rescues
    
        public ActionResult Index()
        {
            return View(db.Rescues.ToList());
        }

        // GET: Rescues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rescues rescues = db.Rescues.Find(id);
            if (rescues == null)
            {
                return HttpNotFound();
            }
            return PartialView(rescues);
        }

        // GET: Rescues/Create
        public ActionResult Create()
        {
            return PartialView();
        }


        // POST: Rescues/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(/*[Bind(Include = "RescueId,RescueName,County_City,Area,RescueAddress,RescueCreatedDate,RescueTel")]*/ Rescues rescues)
        {

            db.Rescues.Add(rescues);
            rescues.RescueCreatedDate = DateTime.Now;

            if (ModelState.IsValid)
            {

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rescues);
        }
        // GET: Rescues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rescues rescues = db.Rescues.Find(id);
            if (rescues == null)
            {
                return HttpNotFound();
            }
            return View(rescues);
        }

        // POST: Rescues/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RescueId,RescueName,County_City,Area,RescueAddress,RescueCreatedDate,RescueTel")] Rescues rescues)
        {

            rescues.RescueCreatedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Entry(rescues).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rescues);
        }

        // GET: Rescues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rescues rescues = db.Rescues.Find(id);
            if (rescues == null)
            {
                return HttpNotFound();
            }
            return View(rescues);
        }

        // POST: Rescues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rescues rescues = db.Rescues.Find(id);
            db.Rescues.Remove(rescues);
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
