using System.Web;
using System.Web.Mvc;

namespace Aula_07___UsandoAreas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}