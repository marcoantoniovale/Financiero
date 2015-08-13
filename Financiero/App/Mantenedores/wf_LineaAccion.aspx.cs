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
    }
}