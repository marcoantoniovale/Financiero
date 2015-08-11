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
                
            }
            else
            {
                Alerta.Text = "No Se ha guardado correctamente";

            }
           

        }

        void getTableRegion()
        {
            int contador = 0;
            RegionDao regDao = new RegionDao();
            

            //Populating a DataTable from database.
        DataTable dt = regDao.getTableRegion();
 
        //Building an HTML string.
        StringBuilder html = new StringBuilder();
 
        //Table start.
        html.Append("<table class='table table-bordered'");
 
        //Building the Header row.
        html.Append("<tr>");
      
            html.Append("<th>");
            html.Append("Id Región");
            html.Append("</th>");

            html.Append("<th>");
            html.Append("Nombre De Región");
            html.Append("</th>");

            html.Append("<th>");
            html.Append("Nombre Corto de Región");
            html.Append("</th>");

            html.Append("<th>");
            html.Append("Modificar");
            html.Append("</th>");

            html.Append("<th>");
            html.Append("Eliminar");
            html.Append("</th>");
        
        html.Append("</tr>");
 
        //Building the Data rows.
        foreach (DataRow row in dt.Rows)
        {
            contador++;
            html.Append("<tr class='table-title'>");
            
            DataColumn dc = new DataColumn();
            foreach (DataColumn column in dt.Columns)
            { 
                
                html.Append("<td>");
                html.Append("<div>"+row[column.ColumnName]+"</div>");
                html.Append("</td>");           
                
            }


            html.Append("<td><a href='#' id='btnModificar" + contador + "' onClick='getDate(" + row[0] + ")'>Modificar<a></td>");       
            html.Append("<td><a href='#' id='btnEliminar"+contador+"' onClick='getDate()'>Eliminar<a></td>");          
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
            //getTableRegion();
           /*StringBuilder html = new StringBuilder();
            html = null;
            html.Append("<input type='text'>");*/
            /*String html = "<input type='text'>";
            //PlaceHolderPrueba.Controls.Add(new Literal { Text = html.ToString() });
            Literal b = new Literal { Text = html.ToString() };
            html.ToString();*/
            String var1 = "Hola1";
            String var2 = "Hola2";
            
            return var1 + "@" + var2;
        }



       public static String getTableRegion2()
       {
           
           int contador = 0;
           RegionDao regDao = new RegionDao();


           //Populating a DataTable from database.
           DataTable dt = regDao.getTableRegion();

           //Building an HTML string.
           StringBuilder html2 = new StringBuilder();

           //Table start.
           html2.Append("<table class='table table-bordered'");

           //Building the Header row.
           html2.Append("<tr>");

           html2.Append("<th>");
           html2.Append("Id Región");
           html2.Append("</th>");

           

           html2.Append("</tr>");

           
           //Table end.
           html2.Append("</table>");

           //Append the HTML string to Placeholder.
           //PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
           //PlaceHolderPrueba.Controls.Add(new Literal { Text = html2.ToString() });

           return html2.ToString();
       }
        

       

        
        }
         
 }
