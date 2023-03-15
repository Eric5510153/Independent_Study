using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TIDIP_ADO_NET_V2.Models;

namespace TIDIP_ADO_NET_V2.Controllers
{
    public class LoginController : Controller
    {

        TIDIP_V2Entities2 db =new TIDIP_V2Entities2();


        // GET: LoginDefault
        public ActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Login(VMLogin vMLogin)
        {
            var adm = db.Admins.Where(Admins => Admins.AdAccount == vMLogin.Account && Admins.AdPassword == vMLogin.Password).FirstOrDefault();

            if (adm == null)
            {
                ViewBag.ErrMsg = "帳號或密碼錯誤";
                return View();

            }

            Session["adm"] = adm;
            return RedirectToAction("Index", "Disaster_Accident");
        }

        public ActionResult Logout()
        {

            Session["adm"] = null;
            return RedirectToAction("Index", "Disaster_Accident");
        }

        public ActionResult MBLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MBLogin(VMLogin vMLogin)
        {
            //注意是否有做雜湊 (Hash)
            var mb = db.Members.Where(m => m.MbAccount == vMLogin.Account && m.MbPassword == vMLogin.Password).FirstOrDefault();

            if (mb == null)
            {
                ViewBag.ErrMsg = "帳號或密碼錯誤";
                return View(vMLogin);
            }

            Session["mb"] = mb;
            return RedirectToAction("Index", "Disaster_Accident");

        }

        public ActionResult MBLogout()
        {

            Session["mb"] = null;
            return RedirectToAction("Index", "Disaster_Accident");
        }
    }
}