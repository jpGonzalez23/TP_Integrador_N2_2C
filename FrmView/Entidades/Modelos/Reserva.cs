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
    public delegate void DelegadoNuevaReserva();

    public class Reserva : IReserva
    {
        public event DelegadoNuevaReserva OnNuevaReserva;

        private CancellationTokenSource cancellationToken;
        private Task tarea;

        public Reserva() { }
        private Comensal comensal;

        public bool AbrirRestaurante
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running || this.tarea.Status == TaskStatus.WaitingToRun || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.AbrirRestaurante)
                {
                    this.cancellationToken = new CancellationTokenSource();
                    this.IniciarReserva();
                }
            }
        }

        public bool Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IniciarReserva()
        {
            CancellationToken token = this.cancellationToken.Token;

            this.tarea = Task.Run(() =>
            {
                while (!this.cancellationToken.IsCancellationRequested)
                {
                    this.NotificarNuevaReserva();
                }
            }, token);
        }

        public void NotificarNuevaReserva()
        {
            if (this.OnNuevaReserva is not null)
            {
                this.comensal = new Comensal();
                this.OnNuevaReserva.Invoke();
            }
        }
    }
}
