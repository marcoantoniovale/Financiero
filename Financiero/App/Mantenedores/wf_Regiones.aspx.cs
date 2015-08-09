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
            int asd = 0;
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
            asd++;
            html.Append("<tr class='table-title'>");
            

            foreach (DataColumn column in dt.Columns)
            {
                
                html.Append("<td>");
               html.Append(row[column.ColumnName]);
                html.Append("</td>");
               
            }
            html.Append("<td>");
            html.Append("adasd"+asd);
            html.Append("</td>");
            html.Append("<td>");
            html.Append("adasd" + asd);
            html.Append("</td>");         
            html.Append("</tr>");
        }
 
        //Table end.
        html.Append("</table>");
 
        //Append the HTML string to Placeholder.
        PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });


        }

       [System.Web.Services.WebMethod(BufferResponse = false)]
        public String asd()
        {
            String asd = "";
            return asd;
        }
        

       

        
        }
         
 }
