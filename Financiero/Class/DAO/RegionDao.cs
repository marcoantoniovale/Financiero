using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Financiero.Class.DAO
{
    public class RegionDao
    {

        Database db = new Database();
        private SqlCommand cmd;


        public String insertRegion(String descripcion, String descripcionCorta)
        {
            String msj = "";
            //SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                String sql = "exec pa_InsertParRegion '"+descripcion+"' , '"+descripcionCorta+"'";
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



        public SqlDataAdapter getRegion()
        {
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                String sql = "SELECT * FROM parRegion";
                this.cmd = new SqlCommand(sql, db.getConex());
                da = new SqlDataAdapter(cmd.CommandText, db.getConex());
            }
            catch (Exception ex)
            {

            }

            return da;
        }

        public DataTable getTableRegion()
        {
            DataTable dt = new DataTable();
            getRegion().Fill(dt);

            return dt;
        }



    }
}