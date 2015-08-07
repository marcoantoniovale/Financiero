using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Financiero
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.EnableFriendlyUrls();
            routes.MapPageRoute("rutaCdp", "generarCDP", "~/App/CDP/generarCDP.aspx", false);
            routes.MapPageRoute("rutaVerCdp", "VerCDP", "~/App/CDP/VerCDP.aspx", false);
            
        }
    }
}
