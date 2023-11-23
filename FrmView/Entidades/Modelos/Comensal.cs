using Entidades.Enumerados;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Comensal : IComensal
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

        private List<EMesas> mesaAsignada;
        private Random random;

        /// <summary>
        /// Constructor sin parametro
        /// </summary>
        public Comensal():this("", 0, 0, DateTime.Now)
        {
        }

        /// <summary>
        /// Sobre carga del constructor
        /// </summary>
        /// <param name="nombre">Recibe un nombre en string</param>
        /// <param name="dni">Recibe un dni en int</param>
        /// <param name="cantComensales">Recibe la cantidad de comensales en int</param>
        /// <param name="horario">Recibe el horario en DateTime</param>
        public Comensal(string nombre, int dni, int cantComensales, DateTime horario)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.cantComensales = cantComensales;
            this.horario = horario;
            this.random = new Random();
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
        /// Metodo para mostrar por los datos del comensal
        /// </summary>
        /// <returns>Retorna una cadena de string</returns>
        string IComensal.Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.Nombre} | ");
            sb.Append($"DNI: {this.Dni} | ");
            sb.Append($"Cantidad de comensales: {this.cantComensales} | ");
            sb.Append($"Horario de reserva: {this.Horario} | ");
            //sb.Append($"Mesa Asignada: {}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo para asignar una mesa
        /// </summary>
        public void AsignarMesa()
        {
            this.mesaAsignada = this.random.AsignarMesaAleatoria();
        }

        /// <summary>
        /// Polimorfismo del metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ((IComensal)this).Mostrar();
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

        public static bool operator ==(Comensal a, Comensal b) 
        {
            return a.dni == b.dni;
        }

        public static bool operator !=(Comensal a, Comensal b)
        {
            return !(a == b);
        }
    }
}
