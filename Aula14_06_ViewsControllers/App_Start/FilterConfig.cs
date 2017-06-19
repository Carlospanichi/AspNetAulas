using System.Web;
using System.Web.Mvc;

namespace Aula14_06_ViewsControllers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
