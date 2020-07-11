using System.Web;
using System.Web.Mvc;

namespace HPlus.EcommerceLinkedIn
{
    public class FilterConfig
    {
        // Filtro global: Maneja cualquier error no manejable
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
