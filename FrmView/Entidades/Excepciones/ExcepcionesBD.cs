using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionesBD : Exception
    {
        public ExcepcionesBD(string? message) : base(message)
        {
        }

        public ExcepcionesBD(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
