using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionesBD : Exception
    {
        /// <summary>
        /// Cosntructor que hereda de Exception
        /// </summary>
        /// <param name="message">Se le pasa un mensaje</param>
        public ExcepcionesBD(string? message) : base(message)
        {
        }

        /// <summary>
        /// Sobre carga de constructor que hereda de Exception
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        /// <param name="innerException">Recibe una excepcion</param>
        public ExcepcionesBD(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
