using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEquipo
    {
    public abstract class Persona : IUsuario
        {
        private string nombre;
        private string apellidos;
        private string departamento;

        public string Nombre { get => nombre; set => nombre=value; }
        public string Apellidos { get => apellidos; set => apellidos=value; }
        public string Departamento { get => departamento; set => departamento=value; }

        protected Persona(string nombre, string apellidos, string departamento)
            {
            Nombre=nombre;
            Apellidos=apellidos;
            Departamento=departamento;
            }

        public DateTime CalcularFechaDevolucion()
            {
            throw new NotImplementedException();
            }

        public DateTime CalcularSancion()
            {
            throw new NotImplementedException();
            }
        }
    }
