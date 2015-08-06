using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Financiero.Class
{
    public class Database
    {
        private SqlConnection D_cn;
        private SqlCommand D_cmd;
        private String status;


        public Database()
        {
            try
            {
                this.D_cn = new SqlConnection("Data Source=localhost; Initial Catalog=Financiero ; User ID=sa; Password=123");
                this.D_cn.Open();
                this.status = "Conexion exitosa";
            }
            catch (Exception ex)
            {
                this.status = "Error: " + ex.ToString();
            }
        }

        public void consulta(String query)
        {
            this.D_cmd = new SqlCommand(query, this.D_cn);
            this.D_cmd.ExecuteNonQuery();
        }

        public SqlConnection getConex()
        {
            return this.D_cn;
        }

        public String getStatus()
        {
            return this.status;
        }
    }
}