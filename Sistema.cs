using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace TP2_Lab
{
    public class Sistema
    {
        private ArrayList listaPropiedad;

        public Sistema()
        {
            listaPropiedad = new ArrayList();
        }

        public void AgregarPropiedad(Propiedad miPropiedad)
        {
            listaPropiedad.Add(miPropiedad);
        }
        public void RemoverPropiedad(Propiedad miPropiedad)
        {
            Propiedad aux = BuscarPropiedad(miPropiedad);
            if(aux != null)
            {
                listaPropiedad.Remove(aux);
            }
        }
        public Propiedad BuscarPropiedad(Propiedad miPropiedad)
        {
            listaPropiedad.Sort();
            int pos = listaPropiedad.BinarySearch(miPropiedad);
            Propiedad aux;
            aux = (Propiedad)listaPropiedad[pos];
            return aux;
        }
        public Reserva BuscarReserva(Reserva miReserva)
        {
            listaPropiedad.Sort();
            int pos = listaPropiedad.BinarySearch(miReserva);
            Reserva aux;
            aux = (Reserva)listaPropiedad[pos];
            return aux;
        }
        public void CancelarReserva(Reserva miReserva)
        {
            Reserva aux = BuscarReserva(miReserva);
            if (aux != null)
            {
                listaPropiedad.Remove(aux);
            }
        }

        public bool iniciarReserva(DateTime fechaIngreso, int diasEstadia)
        {
            bool ret = false;
            /*
             Codigo para verificar días a reservar en el Calendar
             */
            return ret;
        }
    }
}
