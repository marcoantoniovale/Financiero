using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Financiero.Class.DAO;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;

namespace Financiero.App.Mantenedores
{
    public partial class wf_Regiones : System.Web.UI.Page
    {

        StringBuilder html2 = new StringBuilder();



        protected void Page_Load(object sender, EventArgs e)
        {
            getTableRegion();
            Alerta.Text = "";

        }

        protected void btnGuardarRegion_Click(object sender, EventArgs e)
        {
            Alerta.Enabled = true;
            String strManRegionDescripcion = txtManRegion.Text;
            String strManRegionNomCorto = txtManRegionNombreCorto.Text;

            RegionDao regDao = new RegionDao();
            if (regDao.insertRegion(strManRegionDescripcion, strManRegionNomCorto) == "Ok")
            {
                Alerta.Text = "Se ha guardado correctamente";
                Response.Redirect("MantenedorRegion");
                
            }
            else
            {
                Alerta.Text = "No Se ha guardado correctamente";

            }
           

        }

        void getTableRegion()
        {
            int contadorRegistrosRegion = 0;
            RegionDao regDao = new RegionDao();
                //Populating a DataTable from database.
            DataTable dt = regDao.getTableRegion();
 
            //Building an HTML string.
            StringBuilder html = new StringBuilder();
 
            //Table start.
            html.Append("<table class='table table-bordered'");
 
            //Building the Header row.
               html.Append("<tr>");
               html.Append("<th>Id Región</th>");               
               html.Append("<th>Nombre De Región</th>");
               html.Append("<th>Nombre Corto de Región</th>");  
               html.Append("<th>Modificar</th>");
               html.Append("<th>Eliminar</th>");
               html.Append("</tr>");
 
            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                contadorRegistrosRegion++;
                html.Append("<tr class='table-title'>");
            
                DataColumn dc = new DataColumn();
                foreach (DataColumn column in dt.Columns)
                {                
                    html.Append("<td>");
                    html.Append("<div>"+row[column.ColumnName]+"</div>");
                    html.Append("</td>");                           
                }

                html.Append("<td><a href='#' id='btnModificar" + contadorRegistrosRegion + "' onClick='getDate(" + row[0] + ")'>Modificar<a></td>");
                html.Append("<td><a href='#' id='btnEliminar" + contadorRegistrosRegion + "' onClick='getDate()'>Eliminar<a></td>");          
                html.Append("</tr>");
            }
 
            //Table end.
            html.Append("</table>");
 
            //Append the HTML string to Placeholder.
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            //PlaceHolderPrueba.Controls.Add(new Literal { Text = html.ToString() });

            
        }
    



       [System.Web.Services.WebMethod]
        public static String getDate()
        {
            
            String var1 = "Hola1";
            String var2 = "Hola2";
            
            return var1 + "@" + var2;
        }
        
       }
         
 }
