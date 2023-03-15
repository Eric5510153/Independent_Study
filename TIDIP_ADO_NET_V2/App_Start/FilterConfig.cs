using System.Web;
using System.Web.Mvc;

namespace TIDIP_ADO_NET_V2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
