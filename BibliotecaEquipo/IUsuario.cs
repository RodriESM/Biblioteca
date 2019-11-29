using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEquipo
    {
    interface IUsuario
        {
        DateTime CalcularFechaDevolucion();
        DateTime CalcularSancion();

        }
    }
