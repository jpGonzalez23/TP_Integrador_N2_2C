using Entidades.Archivo;
using Entidades.Excepciones;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public delegate void DelegadoDemoraReserva(double demora);
    
    public delegate void DelegadoNuevaReserva(IReserva reserva);

    public class Reserva<T> : IReserva
    {
        private event DelegadoDemoraReserva OnDemora;
        private event DelegadoNuevaReserva OnReserva;

        private List<Comensal> comensals;

        private string nombreLocal;
        private int cantReservasFinalizadas;
        private double demoraNuevaReserva;

        private CancellationTokenSource cancellation;
        private Task tarea;


        private Reserva()
        {
            this.comensals = new List<Comensal>();
        }

        public Reserva(string nombreLocal) : this()
        {
            this.nombreLocal = nombreLocal;
        }

        public bool HabiliatarReserva
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running
                                              || this.tarea.Status == TaskStatus.WaitingToRun
                                              || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.HabiliatarReserva)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarReserva();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        public double TiempoDemoraDeAtencion
        {
            get => this.cantReservasFinalizadas == 0 ? 0 : this.demoraNuevaReserva / this.cantReservasFinalizadas;
        }

        public string Nombre
        {
            get => this.nombreLocal;
        }

        public int CantReservasFinalizadas
        {
            get => this.cantReservasFinalizadas;
        }

        public string ComprobanteReserva => throw new NotImplementedException();

        public void IniciarReserva()
        {
            CancellationToken token = this.cancellation.Token;

            this.tarea = Task.Run(() =>
            {
            while (!token.IsCancellationRequested)
            {
                this.EsperarProximaResera();
                }
            }, token);
        }

        private void EsperarProximaResera()
        {
            int tiempoEspera = 0;
            
            while (this.OnDemora is not null && this.cancellation.IsCancellationRequested)
            {
                tiempoEspera++;
                this.OnDemora.Invoke(tiempoEspera);
                Thread.Sleep(1000);
            }
            this.demoraNuevaReserva += tiempoEspera;
        }
        
    }
}
