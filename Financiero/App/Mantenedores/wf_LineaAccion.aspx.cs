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
    public partial class wf_LineaAccionaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Alerta.Text = "";
            getTableLineaAccion();
        }

        protected void btnGuardarLinea_Click(object sender, EventArgs e)
        {
            Alerta.Enabled = true;
            String strManLineaDescripcion = txtManLinea.Text;
         

            LineaAccionDao linDao = new LineaAccionDao();
            if (linDao.insertLinea(strManLineaDescripcion) == "Ok")
            {
                Alerta.Text = "Se ha guardado correctamente";

            }
            else
            {
                Alerta.Text = "No Se ha guardado correctamente";

            }
        }

        void getTableLineaAccion()
        {
            int contadorRegistrosLineaAccion = 0;
            LineaAccionDao laDao = new LineaAccionDao();
            //Populating a DataTable from database.
            DataTable dt = laDao.getTableLineaAccion();

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table table-bordered'");

            //Building the Header row.
            html.Append("<tr>");
            html.Append("<th>Id LineaAccion</th>");
            html.Append("<th>Nombre De Linea Accion</th>");
            html.Append("<th>Modificar</th>");
            html.Append("<th>Eliminar</th>");
            html.Append("</tr>");

            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                contadorRegistrosLineaAccion++;
                html.Append("<tr class='table-title'>");

                DataColumn dc = new DataColumn();
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append("<div>" + row[column.ColumnName] + "</div>");
                    html.Append("</td>");
                }

                html.Append("<td><a href='#' id='btnModificar" + contadorRegistrosLineaAccion + "' onClick='getDate(" + row[0] + ")'>Modificar<a></td>");
                html.Append("<td><a href='#' id='btnEliminar" + contadorRegistrosLineaAccion + "' onClick='getDate()'>Eliminar<a></td>");
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            //Append the HTML string to Placeholder.
            ph_LineaAccion.Controls.Add(new Literal { Text = html.ToString() });
            //PlaceHolderPrueba.Controls.Add(new Literal { Text = html.ToString() });


        }
    }
}