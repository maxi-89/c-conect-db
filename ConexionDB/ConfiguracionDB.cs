using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    internal class ConfiguracionDB
    {
        // es un singleton
        private string servidor, baseDeDatos, usuario, clave;

        private static ConfiguracionDB instancia = null;
        private ConfiguracionDB()
        {
            servidor = ConfigurationManager.AppSettings["BDServidor"];
            baseDeDatos = ConfigurationManager.AppSettings["BDBase"];
            usuario = ConfigurationManager.AppSettings["BDUsuario"];
            clave = ConfigurationManager.AppSettings["BDClave"];
        }

        public static string obtenerStringdeConexion()
        {
            crearInstancia();
           // return "User ID=postgres;Password=noe420472;Host=127.0.0.1;Port=5432;Database=sa;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;";
            return "Data Source=" + instancia.servidor + ";Initial Catalog="
                     + instancia.baseDeDatos +
                    ";Persist Security Info=True;User ID=" +
                  instancia.usuario + ";Password=" + instancia.clave;
        }

        private static void crearInstancia()
        {
            if (instancia == null) instancia = new ConfiguracionDB();
        }
    }
}
