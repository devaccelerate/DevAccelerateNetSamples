using System.Web;
using System.Web.Mvc;

namespace Ejyle.DevAccelerate.Samples.AspNetWebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
