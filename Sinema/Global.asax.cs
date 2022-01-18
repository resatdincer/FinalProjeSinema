using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Sinema.Model;

namespace Sinema
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelSinema DB = new ModelSinema();
            DB.Database.CreateIfNotExists(); //proje ayağa kalktığında veritabanına bakar yok ise gider veritabanını oluşturur. Webconfig den bağlantı ayarlarını o bilgisayara göre değiştirmek gerekir.


        }
    }
}