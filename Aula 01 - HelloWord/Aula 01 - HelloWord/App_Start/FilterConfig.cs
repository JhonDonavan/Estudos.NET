using System.Web;
using System.Web.Mvc;

namespace Aula_01___HelloWord
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}