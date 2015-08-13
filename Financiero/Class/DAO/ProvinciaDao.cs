using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Financiero.Class.DAO
{
    public class ProvinciaDao
    {
        Database db = new Database();
        private SqlCommand cmd;
        public String insertProvincia(String idRegion, String nombre)
        {
            String msj = "";
            //SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                String sql = "exec pa_InserParProvincia '" + nombre + "' , " + idRegion + "";
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


    }
}