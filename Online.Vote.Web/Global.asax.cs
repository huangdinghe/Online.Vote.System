using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Online.Vote.Core;
using Online.Vote.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Online.Vote.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region Fields
        private Container container;
        #endregion
        protected void Application_Start()
        {
            IConfigurationSource source = System.Configuration.ConfigurationManager.GetSection("activerecord") as IConfigurationSource;
            ActiveRecordStarter.Initialize(typeof(Users).Assembly, source);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            container = Container.Instance;
        }
        protected void Application_End(object sender, EventArgs e)
        {
            container.Dispose();
        }
    }
}
