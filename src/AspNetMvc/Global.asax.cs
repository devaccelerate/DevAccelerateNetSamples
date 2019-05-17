using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ejyle.DevAccelerate.Core;
using Ejyle.DevAccelerate.Core.Configuration;
using Ejyle.DevAccelerate.Core.Data;
using Ejyle.DevAccelerate.EnterpriseSecurity.Apps;
using Ejyle.DevAccelerate.Identity;
using Ejyle.DevAccelerate.Mail;
using Ejyle.DevAccelerate.Sms;

namespace Ejyle.DevAccelerate.Samples.AspNetMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var configSource = new DaDefaultConfigurationSource();

            DaInitializationManager.AddModuleInitializer(new DaDefaultDataInitializer(configSource));
            DaInitializationManager.AddModuleInitializer(new DaDefaultAppsInitializer(configSource));
            DaInitializationManager.AddModuleInitializer(new DaDefaultIdentityInitializer(configSource));
            DaInitializationManager.AddModuleInitializer(new DaDefaultMailInitializer(configSource));
            DaInitializationManager.AddModuleInitializer(new DaDefaultSmsInitializer(configSource));

            DaInitializationManager.Execute();
        }
    }
}
