using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB
{
    internal interface ITable
    {
        bool VerTablaPrimero(string sp);
        bool VerTablaSiguiente();
        bool VerTablaFinalizar();

    }
}
