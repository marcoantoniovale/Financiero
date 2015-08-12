using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Financiero.Class.DAO
{
    public class LineaAccionDao
    {
        Database db = new Database();
        private SqlCommand cmd;


        public String insertLinea(String descripcion)
        {
            String msj = "";
            //SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                String sql = "exec pa_InsertLineaAccion '" + descripcion +"'";
                this.cmd = new SqlCommand(sql, db.getConex());
                this.cmd.ExecuteNonQuery();
                msj = "Ok";
            }
            catch (Exception ex)
            {
                msj = "Error";
            }

            return msj;
        }



        public SqlDataAdapter getLineaAccion()
        {
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                String sql = "SELECT * FROM parLineaAccion";
                this.cmd = new SqlCommand(sql, db.getConex());
                da = new SqlDataAdapter(cmd.CommandText, db.getConex());
            }
            catch (Exception ex)
            {

            }

            return da;
        }

    }
}