using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Comensal
    {
        private int idComensal;
        private string nombre;
        private int numeroMesa;
        private int dni;
        private int cantComensales;
        private DateTime horario;

        public Comensal()
        {

        }

        public Comensal(string nombre, int dni, int cantComensales, DateTime horario):this()
        {
            this.nombre = nombre;
            this.dni = dni;
            this.cantComensales = cantComensales;
            this.horario = horario;
        }

        public int IdComensal
        {
            get => this.idComensal;
            set
            {
                if (value > 0)
                {
                    this.idComensal = value;
                }
            }
        }
        public string Nombre
        {
            get => this.nombre;
            set
            {
                if (this.ValidarStringVacio(value))
                {
                    this.nombre = value;
                }
            }
        }

        public DateTime Horario
        {
            get => this.horario;
            set => this.horario = value;
        }

        public int Dni
        {
            get => this.dni;
            //set => this.dni = value;
            set
            {
                if (value > 0)
                {
                    this.dni = value;
                }
            }
        }

        public int CantComensales
        {
            get => this.cantComensales;
            set
            {
                if (value > 0)
                {
                    this.cantComensales = value;
                }
            }
        }

        public int NumeroMesa
        {
            get => this.numeroMesa;
            set
            {
                this.numeroMesa = value;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} | DNI: {this.Dni} | Cantidad de comensales: {this.cantComensales} | Horario de reserva: {this.Horario}";
        }

        private bool ValidarStringVacio(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? false : true;
        }
    }
}
