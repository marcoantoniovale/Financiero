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
            routes.MapPageRoute("rutaGenCdp", "generarCDP", "~/App/CDP/wf_generarCDP.aspx", false);
            routes.MapPageRoute("rutaVerCdp", "VerCDP", "~/App/CDP/wf_VerCDP.aspx", false);
            routes.MapPageRoute("rutaMantenedorwf_Region", "MantenedorRegion", "~/App/Mantenedores/wf_Regiones.aspx", false);
            routes.MapPageRoute("rutaMantenedrwf_ModeloAtencion", "MantenedorModAtencion", "~/App/Mantenedores/wf_ModeloAtencion.aspx", false);
            routes.MapPageRoute("rutaMantenedrwf_LineaAccion", "MantenedorLineaAccion", "~/App/Mantenedores/wf_LineaAccion.aspx", false);
            routes.MapPageRoute("rutaMantenedrwf_Provincias", "MantenedorProvincias", "~/App/Mantenedores/wf_Provincias.aspx", false);
            routes.MapPageRoute("rutaMantenedrwf_ModeloIntervencion", "ManenedorModIntervencion", "~/App/Mantenedores/wf_ModeloIntervencion.aspx", false);
        }
    }
}
