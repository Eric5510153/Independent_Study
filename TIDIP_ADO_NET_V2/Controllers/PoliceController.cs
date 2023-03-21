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
    public class PoliceController : Controller
    {
        private TIDIP_V2Entities2 db = new TIDIP_V2Entities2();

        //GET: Police
        GetData gd = new GetData();
        public ActionResult PoliceIndex()
        {

            string sql = "select * from Police";
            var police = gd.TableQuery(sql);

            return View(police);


        }

        //[OutputCache(Duration = 86400, Location = OutputCacheLocation.Any)]
        public ActionResult Index()
        {
            var result = db.Police.ToList();  //.Take(100)

            return View(result);
        }

        // GET: Police/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Police police = db.Police.Find(id);
            if (police == null)
            {
                return HttpNotFound();
            }
            //return PartialView(police);
            return View(police);
        }

        // GET: Police/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Police/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(/*[Bind(Include = "PoliceID,PoliceName,County_City,Area,PoliceAddress,PoliceCreatedDate,PoliceTel")]*/ Police police)
        {
            db.Police.Add(police);
            police.PoliceCreatedDate = DateTime.Now;
            if (ModelState.IsValid)
            {



                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(police);
        }

        // GET: Police/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Police police = db.Police.Find(id);
            if (police == null)
            {
                return HttpNotFound();
            }
            return View(police);
        }

        // POST: Police/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PoliceID,PoliceName,County_City,Area,PoliceAddress,PoliceCreatedDate,PoliceTel")] Police police)
        {

            police.PoliceCreatedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Entry(police).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(police);
        }

        // GET: Police/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Police police = db.Police.Find(id);
            if (police == null)
            {
                return HttpNotFound();
            }
            return View(police);
        }

        // POST: Police/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Police police = db.Police.Find(id);
            db.Police.Remove(police);
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
