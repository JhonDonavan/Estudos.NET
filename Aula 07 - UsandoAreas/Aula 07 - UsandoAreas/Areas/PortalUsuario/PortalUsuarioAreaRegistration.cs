using System.Web.Mvc;

namespace Aula_07___UsandoAreas.Areas.PortalUsuario
{
    public class PortalUsuarioAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PortalUsuario";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PortalUsuario_default",
                "PortalUsuario/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
