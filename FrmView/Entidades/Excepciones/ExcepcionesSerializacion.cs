using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionesSerializacion : Exception
    {
        public ExcepcionesSerializacion(string? message) : base(message)
        {
        }

        public ExcepcionesSerializacion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
