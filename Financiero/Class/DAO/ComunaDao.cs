using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Financiero.Class.DAO
{
    public class ComunaDao
    {
        Database db = new Database();
        private SqlCommand cmd;
        public SqlDataAdapter getComuna()
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

    }
}