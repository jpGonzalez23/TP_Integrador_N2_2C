using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Reserva : IReserva
    {
        private static int costoBase;
        private int numeroReserva;
        private int nombreReserva;
        private bool estado;
        List<Cliente> clientes;
        Random random;

        static Reserva() => Reserva.costoBase = 1200;
        public Reserva() : this(false)
        {

        }

        public Reserva(bool estado)
        {
            this.estado = estado;
            this.random = new Random();
        }

        public string ComprobanteReserva => throw new NotImplementedException();

        public void IniciarReserva()
        {
            throw new NotImplementedException();
        }
    }
}
