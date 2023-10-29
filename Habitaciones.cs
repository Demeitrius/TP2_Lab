using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    public class Habitaciones:Propiedad
    {
        private int estrellas;
        private int tipoHabitacion;
        private int nroHabitacion;

        public Habitaciones(int estrellas,string direccion, int nroHabitacion, bool[] servicios, int cantCamas,
            int tipoHabitacion) : base(direccion, cantCamas,servicios)
        {
            this.estrellas = estrellas;
            this.nroHabitacion = nroHabitacion;
            this.tipoHabitacion = tipoHabitacion;
        }

        public override double CalcularPrecio()
        {
            double precioServicios = 0;
            double precio = 0;
            double precioxCamas = 0;

            precioxCamas = cantCamas * 100;

            for(int i = 0; i < 6; i++)
            {
                if(servicios[i] == true)
                {
                    precioServicios += 102;
                }
            }

            if (estrellas == 2)
            {
                if(tipoHabitacion == 1)
                {
                    precio = precioBasico;
                }
                else if(tipoHabitacion == 2)
                {
                    precio = precioBasico + (precioBasico * 0.8);
                }
                else
                {
                    precio = precioBasico + (precioBasico * 1.5);
                }
            }
            else
            {
                if (tipoHabitacion == 1)
                {
                    precio = precioBasico + (precioBasico * 0.4);
                }
                else if (tipoHabitacion == 2)
                {
                    precio = precioBasico + (precioBasico * 1.2);
                }
                else
                {
                    precio = precioBasico + (precioBasico * 1.9);
                }
            }
            //int dias = ((Reserva)((Propiedad)ListaReservas[0]).ListaReservas[0]).DiasAReservar();

            precio += precioServicios + precioxCamas;
            return precio;
        }
    }
}
