using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Financiero.Class.DAO
{
    public class CdpDao
    {
        private SqlCommand cmd;
        Database db = new Database();

        public SqlDataAdapter consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            
            try
            {
                String sql = "SELECT * FROM parModAtencion";
                this.cmd = new SqlCommand(sql, db.getConex());
                da = new SqlDataAdapter(cmd.CommandText, db.getConex());
            }
            catch (Exception ex)
            {

            }

            return da;
        }


        public SqlDataAdapter comuna()
        {
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                String sql = "SELECT * FROM parComuna";
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