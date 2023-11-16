using Entidades.Archivo;
using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{

    public class Reserva<T> : IReserva
    {
        public bool Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IniciarReserva()
        {
            throw new NotImplementedException();
        }
    }
}
