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
    public delegate void DelegadoMostrarReserva();

    public class Reserva
    {
        public event DelegadoMostrarReserva OnReserva;

        private CancellationTokenSource cancellationToken;
        private Task tarea;
        private Comensal comensal;

        public Reserva() 
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AbrirRestaurante
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running || 
                                                  this.tarea.Status == TaskStatus.WaitingToRun || 
                                                  this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.AbrirRestaurante)
                {
                    this.cancellationToken = new CancellationTokenSource();
                }
                else
                {
                    this.cancellationToken.Cancel();
                }
            }
        }
    }
}
