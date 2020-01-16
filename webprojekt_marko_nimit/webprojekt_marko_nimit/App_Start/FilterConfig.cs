using System.Web;
using System.Web.Mvc;

namespace webprojekt_marko_nimit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
