using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing.Text;

namespace TP2_Lab
{
    public abstract class Propiedad: IComparable
    {
        protected double precioBasico;
        protected int cantCamas;
        protected bool estado;
        private ArrayList listaReservas;
        public ArrayList ListaReservas
        {
            get { return listaReservas; }
        }
        protected bool[] servicios = new bool[6];
        protected string direccion;
        
        public Propiedad(string direccion, int cantCamas,bool[]servicios)
        {
            this.direccion = direccion;
            this.cantCamas = cantCamas;
            for(int i = 0; i < 6; i++)
            {
                this.servicios[i] = servicios[i];
            }
            
        }
        public abstract double CalcularPrecio();
        public void AgregarReserva(Reserva miReserva)
        {
            listaReservas.Add(miReserva);
        }
        public int CompareTo(object obj)
        {
            return this.direccion.CompareTo(((Propiedad)obj).direccion);
        }
    }
}
