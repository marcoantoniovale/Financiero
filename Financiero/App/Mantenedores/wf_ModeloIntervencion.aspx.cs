using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Financiero.App.Mantenedores
{
    public partial class wf_ModeloIntervencion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_manModIntPlazas_Click(object sender, EventArgs e)
        {
           
            Session["Hola"] += "@Plazas";
            TextBox1.Text = Session["Hola"].ToString();
        }

        protected void btn_manModIntBorrar_Click(object sender, EventArgs e)
        {
            
            Session["Hola"] = "";
            Response.Redirect("ManenedorModIntervencion");

        }

        protected void btn_manModIntSum_Click(object sender, EventArgs e)
        {
            Session["Hola"] += "+";
            TextBox1.Text = Session["Hola"].ToString();
        }

        protected void btn_manModIntRest_Click(object sender, EventArgs e)
        {
            Session["Hola"] += "-";
            TextBox1.Text = Session["Hola"].ToString();
        }

        protected void btn_manModIntMul_Click(object sender, EventArgs e)
        {
            Session["Hola"] += "*";
            TextBox1.Text = Session["Hola"].ToString();
        }

        protected void btn_manModIntDiv_Click(object sender, EventArgs e)
        {
            Session["Hola"] += "/";
            TextBox1.Text = Session["Hola"].ToString();
        }
    }
}