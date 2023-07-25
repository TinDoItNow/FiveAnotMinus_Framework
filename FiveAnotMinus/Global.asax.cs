using FiveAnotMinus.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FiveAnotMinus
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();
            HttpException httpException = exception as HttpException;
            Response.Clear();
            Server.ClearError();
            RouteData routeData = new RouteData();
            routeData.Values["controller"] = "Error";
            routeData.Values["action"] = "Error404";
            routeData.Values["exception"] = exception;
            Response.StatusCode = 404;
            if (httpException != null)
            {
                Response.StatusCode = httpException.GetHttpCode();
                switch (Response.StatusCode)
                {
                    case 403:
                        routeData.Values["action"] = "Error403";
                        break;
                    case 404:
                        routeData.Values["action"] = "Error404";
                        break;
                    case 500:
                        routeData.Values["action"] = "Error500";
                        break;
                    default:
                        routeData.Values["action"] = "General";
                        break;
                }
            }
            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        }
    }
}
