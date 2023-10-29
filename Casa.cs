using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    public class Casa:Propiedad
    {
        private int diasPermitidos; //dias minimo
        //private int diasTotales;     //dias totales //nico bruto esto si va...
        Propietario miPropietario;

        public Casa(int diasPermitidos,Propietario miPropietario,string direccion, int cantCamas, bool[]servicios)
            :base(direccion,cantCamas,servicios)
        {
            this.diasPermitidos = diasPermitidos;
            miPropietario = new Propietario("Ricardo","Iorio",1123124123124123124);
        }
        public override double CalcularPrecio()
        {
            double precioServicios = 0;
            double precio = 0;
            double precioxCamas = 0;

            precioxCamas = cantCamas * 100;

            for (int i = 0; i < 6; i++)
            {
                if (servicios[i] == true)
                {
                    precioServicios += 102;
                }
            }
            precio += precioServicios + precioxCamas;

            return precio;
        }

        public double DiasAReservar(int dias)
        {
            double ret = diasPermitidos * precioBasico;
            if (dias > diasPermitidos)
               ret += (dias - diasPermitidos) * precioBasico * 0.9;
                
            return ret;
        }
    }
}
