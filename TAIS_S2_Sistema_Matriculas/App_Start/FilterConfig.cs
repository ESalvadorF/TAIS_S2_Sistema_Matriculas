using System.Web;
using System.Web.Mvc;

namespace TAIS_S2_Sistema_Matriculas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
