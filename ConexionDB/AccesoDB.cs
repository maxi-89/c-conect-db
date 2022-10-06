using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    internal class AccesoDB
    {
        static SqlConnection sqlConnection1 = null;
        protected SqlDataReader reader1;
        public AccesoDB()
        {
            if (sqlConnection1 == null)
            {
                try
                {
                    sqlConnection1 = new SqlConnection(
                                            ConfiguracionDB.obtenerStringdeConexion());
                    if (sqlConnection1.State != ConnectionState.Open)
                    { sqlConnection1.Open(); }
                }
                catch (Exception ex)
                { throw new Exception(ex.Message); }
            }
        }

        public void Ejecutar(String strsql)
        {
            SqlCommand cmd1 = new SqlCommand(strsql, sqlConnection1);

            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
        }
        public void finalizar()
        {
            sqlConnection1.Close();
        }
        public SqlConnection ObtenerConexion()
        {
            return sqlConnection1;
        }


    }
}
