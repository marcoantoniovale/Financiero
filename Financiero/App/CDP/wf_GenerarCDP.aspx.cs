using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Financiero.Class;
using Financiero.Class.DTO;
using Financiero.Class.DAO;

namespace Financiero.App.CDP
{
    public partial class GenerarCDP : System.Web.UI.Page
    {
        CdpDao cdp = new CdpDao();
        ComunaDao comunaDao = new ComunaDao();
        
        SqlDataAdapter da = new SqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Database db = new Database();

            cargarComunas();
            cargarRegiones();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        void cargarComunas()
        {
            DataSet ds = new DataSet();

            da = comunaDao.getComuna();
            da.Fill(ds);
            this.ddComuna.DataSource = ds;
            this.ddComuna.DataValueField = "id_comuna";
            this.ddComuna.DataTextField = "descripcion";
            this.ddComuna.DataBind();
            this.ddComuna.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
            /*this.DropDownList1.DataSource = ds;
            this.DropDownList1.DataValueField = "id_comuna";
            this.DropDownList1.DataTextField = "descripcion";
            this.DropDownList1.DataBind();
            this.DropDownList1.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));*/
        }

        private DataTable cargarComunas1()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            da = comunaDao.getComuna();
            da.Fill(dt);
           
            return dt;
           
        }

        void cargarRegiones()
        {
            DataSet ds = new DataSet();
            da = cdp.consulta();
            da.Fill(ds);
         
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}