using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Financiero.Class.DAO;

namespace Financiero.App.Mantenedores
{
    public partial class wf_ModeloIntervencion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["sess_zona"] = "N" ;
            Session["sess_cobertura"] = "N";
            Session["sess_cvf"] = "N";

        }

        protected void btn_manModIntPlazas_Click(object sender, EventArgs e)
        {
           
            Session["sess_CalculoCdp"] += "@Plazas";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_manModIntBorrar_Click(object sender, EventArgs e)
        {

            Session["sess_CalculoCdp"] = "";         
            Session["sess_zona"] = "N";
            Session["sess_cobertura"] = "N";
            Session["sess_cvf"] = "N";
            Response.Redirect("ManenedorModIntervencion");
        }

        protected void btn_manModIntSum_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "+";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_manModIntRest_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "-";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_manModIntMul_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "*";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_manModIntDiv_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "/";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_manModIntPar1_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "(";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();

        }

        protected void btn_manModIntPar2_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += ")";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();

        }


        protected void btn_guatdarManModInt_Click(object sender, EventArgs e)      
        {
            ModeloIntervencionDao mi = new ModeloIntervencionDao();
            //Para Cálculo
            String strNombreCorto = txtManModInterNombreCorto.Text;
            String strFactorFijo = txtManModIntFactorFijo.Text;
            String strFactorVariable = txtManModIntFactorVariable.Text;
            String strFactorEdad = txtManModIntFactorEdad.Text;
            String strFactorComplejidad = txtManModIntFactorComplejidad.Text;
            String strFactorDiscapacidad = txtManModIntFactorDiscapacidad.Text;
            //Validaciones si esta vacío
            String strCalculo = txtCalculoManModInter.Text;
            if (strFactorFijo == "")
            {
                strFactorFijo = "0";

            }
            if (strFactorVariable == "")
            {
                strFactorVariable = "0";

            }
            if (strFactorEdad == "")
            {
                strFactorEdad = "0";

            }
            if (strFactorComplejidad == "")
            {
                strFactorComplejidad = "0";

            }
            if (strFactorDiscapacidad == "")
            {
                strFactorDiscapacidad = "0";

            }

            String existePa = "IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'pa_" + strNombreCorto + "') DROP PROCEDURE pa_" + strNombreCorto + "";
            String sql_Pa = "CREATE PROCEDURE pa_" + strNombreCorto + " ";
            sql_Pa += "@Plazas INT, @FechaDiasHasta DATETIME, @FechaDiasDesde DATETIME, @IdComuna INT ";
            sql_Pa += "AS BEGIN ";
            sql_Pa += "DECLARE @AplicaFactorCobertura VARCHAR(1) ";
            sql_Pa += "SET @AplicaFactorCobertura = '" + Session["sess_cobertura"] + "' ";
            sql_Pa += "DECLARE @AplicaFactorCVF VARCHAR(1) ";
            sql_Pa += "SET @AplicaFactorCVF = '" + Session["sess_cvf"] + "' ";
            sql_Pa += "DECLARE @AplicaFactorZona VARCHAR(1) ";
            sql_Pa += "SET @AplicaFactorZona = '" + Session["sess_cvf"] + "' ";
            sql_Pa += "DECLARE @FactorFijo FLOAT ";
            sql_Pa += "SET @FactorFijo = " + strFactorFijo + " ";
            sql_Pa += "DECLARE @FactorVariable FLOAT ";
            sql_Pa += "SET @FactorVariable = " + strFactorVariable + " ";
            sql_Pa += "DECLARE @FactorEdad FLOAT ";
            sql_Pa += "SET @FactorEdad = "+strFactorEdad+" ";
            sql_Pa += "DECLARE @FactorComplejidad FLOAT ";
            sql_Pa += "SET @FactorComplejidad = "+strFactorComplejidad+" ";
            sql_Pa += "DECLARE @FactorDiscapacidad FLOAT ";
            sql_Pa += "SET @FactorComplejidad = "+strFactorComplejidad+" ";
            sql_Pa += "DECLARE @FactorUSS FLOAT ";
            sql_Pa += "SET @FactorUSS = (";
            sql_Pa += "SELECT TOP 1 FactorAcumulado ";
            sql_Pa += "from DBO.parFactorReajusteUss) ";
            sql_Pa += "DECLARE @FactorCobertura FLOAT ";
            sql_Pa += "BEGIN IF @AplicaFactorCobertura = '"+Session["sess_cobertura"]+"' SET @FactorCobertura = (SELECT FactorCobertura FROM parFactorCobertura WHERE RangoInicial <= @Plazas AND RangoFinal >=@Plazas) END ";
            sql_Pa += "DECLARE @FactorCVF FLOAT ";
            sql_Pa += "BEGIN IF @AplicaFactorCVF = '"+Session["sess_cvf"]+"' ";
            sql_Pa += "SET @FactorCVF= ( ";
            sql_Pa += "SELECT FactorCVF ";
            sql_Pa += "FROM parFactorCobertura ";
            sql_Pa += "WHERE RangoInicial <= @Plazas AND RangoFinal >=@Plazas) END " ;
            sql_Pa += "DECLARE @FactorZona FLOAT ";
            sql_Pa += "BEGIN IF @AplicaFactorZona = '" + Session["sess_zona"] + "' ";
            sql_Pa += "SET @FactorZona = (";
            sql_Pa += "SELECT porcentaje_asig ";
            sql_Pa += "FROM dbo.parComuna ";
            sql_Pa += "WHERE id_comuna = @IdComuna) END ";
            sql_Pa += "DECLARE @Monto money SET @Monto ="+strCalculo+" print @Monto ";
            sql_Pa += "RETURN @Monto END";
            if (mi.creaProcedureSiExiste(existePa) == "Ok")
            {
                Label1.Text = "Si se pudo";

            }
            else
            {
                Label1.Text = mi.creaProcedureSiExiste(existePa);

            }

            if (mi.creaProcedureCalculo(sql_Pa) == "Ok")
            {
                Label1.Text = "Si se pudo el Procedimiento";

            }
            else
            {

                Label1.Text = mi.creaProcedureCalculo(sql_Pa);
            }


        }

        protected void btn_modManIntZona_Click(object sender, EventArgs e)
        {

            Session["sess_CalculoCdp"] += "@FactorZona";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
            Session["sess_zona"] = "S";
        }

        protected void btn_modManIntCobertura_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorCobertura";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
            Session["sess_cobertura"] = "S";
        }

        protected void btn_modManIntCvf_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorCVF";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
            Session["sess_cvf"] = "S";
        }

        protected void btn_modManFactorUss_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorUSS";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();

        }

        protected void btn_ManModIntFactorFijo_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorFijo";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_ManModIntFactorVariable_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorVariable";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_ManModIntFactorEdad_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorEdad";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_ManModIntFactorComplejidad_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorComplejidad";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

        protected void btn_ManModIntFactorDiscapacidad_Click(object sender, EventArgs e)
        {
            Session["sess_CalculoCdp"] += "@FactorDiscapacidad";
            txtCalculoManModInter.Text = Session["sess_CalculoCdp"].ToString();
        }

    }
}