using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Financiero.Class.DAO;

namespace Financiero.App.Mantenedores
{
    public partial class wf_Regiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}