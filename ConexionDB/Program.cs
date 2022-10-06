using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDB
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            try
            {
                AccesoDB bd = new AccesoDB();
                for (int i = 0; i < 10; i++)
                    bd.Ejecutar("insert into pru values (" + i.ToString() + ")");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                TablaDB uno;
                uno = new TablaDB();
                bool sigo = uno.VerTablaPrimero("select * from pru");
                while (sigo)
                {
                    Console.WriteLine(uno.datos.ToString());
                    sigo = uno.VerTablaSiguiente();
                }
                uno.VerTablaFinalizar();
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }



        }
    }
}
