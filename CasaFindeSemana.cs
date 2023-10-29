using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    internal class CasaFindeSemana:Casa
    {
        public CasaFindeSemana(int diasPermitidos, Propietario miPropietario,string direccion,int cantCamas, bool[]servicios)
            :base(diasPermitidos,miPropietario,direccion,cantCamas,servicios)
        {
            diasPermitidos = 1;//?
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
    }
}
