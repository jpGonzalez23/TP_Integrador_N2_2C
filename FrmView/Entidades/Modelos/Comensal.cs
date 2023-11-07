using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Comensal
    {
        /// <summary>
        /// Declaracion de variables
        /// </summary>
        private int idComensal;
        private string nombre;
        private int numeroMesa;
        private int dni;
        private int cantComensales;
        private DateTime horario;

        /// <summary>
        /// Constructor sin parametro
        /// </summary>
        public Comensal()
        {

        }

        /// <summary>
        /// Sobre carga del constructor
        /// </summary>
        /// <param name="nombre">Recibe un nombre en string</param>
        /// <param name="dni">Recibe un dni en int</param>
        /// <param name="cantComensales">Recibe la cantidad de comensales en int</param>
        /// <param name="horario">Recibe el horario en DateTime</param>
        public Comensal(string nombre, int dni, int cantComensales, DateTime horario):this()
        {
            this.nombre = nombre;
            this.dni = dni;
            this.cantComensales = cantComensales;
            this.horario = horario;
        }

        /// <summary>
        /// Propiedad get y set de IdComensal
        /// </summary>
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

        /// <summary>
        /// Propiedad get y set de Nombre
        /// </summary>
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

        /// <summary>
        /// Propiedad get y set de Horario
        /// </summary>
        public DateTime Horario
        {
            get => this.horario;
            set => this.horario = value;
        }

        /// <summary>
        /// Propiedad get y set de Dni
        /// </summary>
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

        /// <summary>
        /// Propiedad get y set de CantComenales
        /// </summary>
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

        /// <summary>
        /// Propiedad get y set de NumeroMesa
        /// </summary>
        public int NumeroMesa
        {
            get => this.numeroMesa;
            set
            {
                this.numeroMesa = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Nombre: {this.Nombre} | DNI: {this.Dni} | Cantidad de comensales: {this.cantComensales} | Horario de reserva: {this.Horario}";
        }

        /// <summary>
        /// Metodo privada para validar que el string no este vacio
        /// </summary>
        /// <param name="valor">Recibe un valors</param>
        /// <returns>Retorna true no es vacio</returns>
        private bool ValidarStringVacio(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? false : true;
        }
    }
}
