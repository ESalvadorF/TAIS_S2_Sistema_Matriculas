using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Helpers;
using TAIS_S2_Sistema_Matriculas.Helpers;
using System.Data.Entity;

namespace TAIS_S2_Sistema_Matriculas
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<
                    Context.DataStore,
                    Migrations.Configuration>());
            this.CheckSuperUserAndRoles();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void CheckSuperUserAndRoles()
        {
            UsersHelper.CheckRole("Customer");
            UsersHelper.CheckRole("Admin");
            UsersHelper.CheckSuperUser();
        }
    }
}
