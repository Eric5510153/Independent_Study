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
    [LoginCheck]
    public class Disaster_Accident_TypeController : Controller
    {
        private TIDIP_V2Entities2 db = new TIDIP_V2Entities2();

        // GET: Disaster_Accident_Type
        public ActionResult Index()
        {
            return View(db.Disaster_Accident_Type.ToList());
        }

        // GET: Disaster_Accident_Type/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disaster_Accident_Type disaster_Accident_Type = db.Disaster_Accident_Type.Find(id);
            if (disaster_Accident_Type == null)
            {
                return HttpNotFound();
            }
            return View(disaster_Accident_Type);
        }

        // GET: Disaster_Accident_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disaster_Accident_Type/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DATypeID,DATypeName")] Disaster_Accident_Type disaster_Accident_Type)
        {

            var DAID = db.Disaster_Accident_Type.Find(disaster_Accident_Type.DATypeID);
            
            if (DAID != null )
            {

                ViewBag.IDRepCheck = "Duplicate ID";
                
                return View(disaster_Accident_Type);
            }
            

            if (ModelState.IsValid)
            {
                db.Disaster_Accident_Type.Add(disaster_Accident_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disaster_Accident_Type);
        }

        // GET: Disaster_Accident_Type/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disaster_Accident_Type disaster_Accident_Type = db.Disaster_Accident_Type.Find(id);
            if (disaster_Accident_Type == null)
            {
                return HttpNotFound();
            }
            return View(disaster_Accident_Type);
        }

        // POST: Disaster_Accident_Type/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DATypeID,DATypeName")] Disaster_Accident_Type disaster_Accident_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disaster_Accident_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disaster_Accident_Type);
        }

        // GET: Disaster_Accident_Type/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disaster_Accident_Type disaster_Accident_Type = db.Disaster_Accident_Type.Find(id);
            if (disaster_Accident_Type == null)
            {
                return HttpNotFound();
            }
            return View(disaster_Accident_Type);
        }

        // POST: Disaster_Accident_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Disaster_Accident_Type disaster_Accident_Type = db.Disaster_Accident_Type.Find(id);
            db.Disaster_Accident_Type.Remove(disaster_Accident_Type);
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
