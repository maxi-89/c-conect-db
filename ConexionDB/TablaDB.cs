using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    internal class TablaDB:AccesoDB, ITable
    {
        public TablaDatos datos;
        SqlCommand cmd1;

        public TablaDB() : base()
        {
            datos = new TablaDatos();
        }

        public bool VerTablaFinalizar()
        {
            reader1.Close();
            return true;


        }

        public bool VerTablaPrimero(string sp)
        {
            cmd1 = new SqlCommand(sp, ObtenerConexion());
            reader1 = cmd1.ExecuteReader();
            return VerTablaSiguiente();
        }

      

        public bool VerTablaSiguiente()
        {
            if (reader1.Read())
            {
                IDataRecord registro;
                registro = (IDataRecord)reader1;
                datos.valor = Int32.Parse(registro["uno"].ToString());

                return true;

            }
            return false;
        }
    }
}
