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
    public class MembersController : Controller
    {
        private TIDIP_V2Entities2 db = new TIDIP_V2Entities2();

        // GET: Members
        //public ActionResult Index()
        //{
        //    return View(db.Members.ToList());
        //}
        public ActionResult Index()
        {

            string MbIdentity = null;
            if (Session["mb"] != null)
            {

                MbIdentity = ((Members)Session["mb"]).MbIdentity;

            }
            var member = db.Members.Where(m => m.MbIdentity == MbIdentity || MbIdentity == null)
                .ToList()
                .OrderByDescending(x => x.MbIdentity);
            return View(member);
        }


        // GET: Members/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(/*[Bind(Include = "MbIdentity,MbName,MbPhone,MbEmail,MbBrithday,MbCreatedDate,MbAccount,MbPassword")]*/ Members members)
        {
           
            var mbID = db.Members.Find(members.MbIdentity);
            var mbEm = db.Members.Where(m => m.MbEmail == members.MbEmail).FirstOrDefault();
            var mbAc = db.Members.Where(m => m.MbAccount == members.MbAccount).FirstOrDefault();
            var mbPh = db.Members.Where(m => m.MbPhone == members.MbPhone).FirstOrDefault();
            if (mbID != null)
            {

                ViewBag.IDRepCheck = "身份證字號已註冊";
                return View(members);
            }

            if (mbPh != null)
            {

                ViewBag.PhRepCheck = "此電話已註冊";
                return View(members);
            }

            if (mbEm != null)
            {

                ViewBag.EmRepCheck = "此電子郵件已註冊";
                return View(members);
            }

            if (mbAc != null)
            {

                ViewBag.AcRepCheck = "帳號已註冊";
                return View(members);
            }

            members.MbCreatedDate = DateTime.Now;
            db.Members.Add(members);
            if (ModelState.IsValid)
            {

                db.SaveChanges();

                return RedirectToAction("MbCreateView");
            }

            return View(members);
        }
        public ActionResult MbCreateView()
        {
            return View(db.Members.ToList());
        }

        // GET: Members/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // POST: Members/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MbIdentity,MbName,MbPhone,MbEmail,MbBrithday,MbCreatedDate,MbAccount,MbPassword")] Members members)
        {
            if (ModelState.IsValid)
            {
                db.Entry(members).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(members);
        }

        // GET: Members/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Members members = db.Members.Find(id);
            db.Members.Remove(members);
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
