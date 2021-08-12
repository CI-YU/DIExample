using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AccountIntegration.Models.Context;
using AccountIntegration.Repository;

namespace AccountIntegration {
  public class WebApiApplication : System.Web.HttpApplication {
    protected void Application_Start() {
      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      // Initialize
      InitializeThreeLayerContext();
    }

    private static void InitializeThreeLayerContext() {
      // TODO : 程式碼示範注入資料來源(進階設計可採用DI Framework注入):Autofac
      InitializeThreeLayerContext_SqlDatabase();
    }    

    private static void InitializeThreeLayerContext_SqlDatabase() {
      // ConnectionString
      string connectionString = "XXXXXXXXXXXXXXXX";

      // Repository,新的注入
      var CustomerRepository = new DA_CustomerRepository(connectionString);

      // Context
      var threeLayerContext = new ThreeLayerContext(CustomerRepository);

      // Initialize
      ThreeLayerContext.Initialize(threeLayerContext);
    }
  }
}
