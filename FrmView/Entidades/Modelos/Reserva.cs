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
        Random random;
        private List<EMesas> comensals;

        private string nombreLocal;
        private int cantReservasFinalizadas;
        private double demoraNuevaReserva;

        private CancellationTokenSource cancellation;
        private Task tarea;

        /// <summary>
        /// Sobre carga de constructor sin parametro
        /// </summary>
        /// <param name="nombreLocal">Recibe el nombre del local</param>
        public Reserva(string nombreLocal)
        {
            this.nombreLocal = nombreLocal;
        }

        /// <summary>
        /// 
        /// </summary>
        public double TiempoDemoraDeAtencion
        {
            get => this.cantReservasFinalizadas == 0 ? 0 : this.demoraNuevaReserva / this.cantReservasFinalizadas;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get => this.nombreLocal;
        }

        /// <summary>
        /// 
        /// </summary>
        public int CantReservasFinalizadas
        {
            get => this.cantReservasFinalizadas;
        }

        public void IniciarReserva()
        {
            throw new NotImplementedException();
        }

        private void SeleccionMesa()
        {
            this.comensals = this.random.AsignarMesaAleatoria();
        }
        
    }
}
