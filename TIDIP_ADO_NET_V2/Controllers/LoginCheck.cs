using TIDIP_ADO_NET_V2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace TIDIP_ADO_NET_V2.Models
{
    public class LoginCheck : ActionFilterAttribute
    {

        void LoginState(HttpContext context)
        {

            if (context.Session["adm"] == null)
            {

                context.Response.Redirect("/Login/Login");

            }

        }
        public override void OnActionExecuting(ActionExecutingContext filterContex)
        {

            HttpContext context = HttpContext.Current;
            LoginState(context);

        }

    
    }
}