using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FileManagerException : Exception
    {
        /// <summary>
        /// Constructor que hereda de Exception
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        public FileManagerException(string? message) : base(message)
        {
        }

        /// <summary>
        /// Sobre carga del constructor
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        /// <param name="innerException">Recibe una exception</param>
        public FileManagerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
