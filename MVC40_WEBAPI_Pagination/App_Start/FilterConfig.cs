using System.Web;
using System.Web.Mvc;

namespace MVC40_WEBAPI_Pagination
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}