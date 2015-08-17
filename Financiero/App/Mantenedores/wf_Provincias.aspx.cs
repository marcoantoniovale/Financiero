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


namespace Financiero.App.Mantenedores
{
    public partial class wf_Provincias : System.Web.UI.Page
    {
        SqlDataAdapter da = new SqlDataAdapter();
        RegionDao regdao = new RegionDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarRegiones();
        }

        public void cargarRegiones()
        {
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();

                da = regdao.getRegion();
                da.Fill(ds);

                ddlRegion.AppendDataBoundItems = true;

                ListItem oItem = new ListItem("Eliga una region...", "0");
                this.ddlRegion.Items.Add(oItem);
                this.ddlRegion.DataSource = ds;
                this.ddlRegion.DataValueField = "id_Region";
                this.ddlRegion.DataTextField = "descripcion";
                this.ddlRegion.DataBind();

            }
        }

        protected void btnGuardarProvincia_Click(object sender, EventArgs e)
        {

            Alerta.Enabled = true;

            int strManProvinciaRegion = int.Parse(ddlRegion.SelectedItem.Value);
            ddlRegion.SelectedValue.ToString();
            /*
            String strManProvinciaNombre = txtManProvincia.Text;

            ProvinciaDao provDao = new ProvinciaDao();
            if (provDao.insertProvincia(strManProvinciaRegion, strManProvinciaNombre) == "Ok")
            {
               Alerta.Text = "Se ha guardado correctamente";
               Response.Redirect("MantenedorProvincias");

            }
            else
            {
                

            }*/
            

            Alerta.Text = ddlRegion.SelectedItem.Text + " - " + ddlRegion.SelectedValue.ToString() + " - " + ddlRegion.SelectedItem.Value;            
        }
    }


}