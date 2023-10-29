using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    public class Propietario
    {
        private string nombre;
        private string apellido;
        private long dni;

        public Propietario(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override string ToString()
        {
            return "Propietario: " + nombre + " " + apellido;
        }
    }
}
