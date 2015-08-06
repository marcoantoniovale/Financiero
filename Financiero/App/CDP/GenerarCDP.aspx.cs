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
        cdpDAO cdp = new cdpDAO();
        
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

            da = cdp.comuna();
            da.Fill(ds);
            /*this.DropDownList1.DataSource = ds;
            this.DropDownList1.DataValueField = "id_comuna";
            this.DropDownList1.DataTextField = "descripcion";
            this.DropDownList1.DataBind();
            this.DropDownList1.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));*/
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