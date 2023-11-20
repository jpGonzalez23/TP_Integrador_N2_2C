using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IBaseDeDatos
    {
        bool GuardarNuevaReserva(Comensal comensal);
    }
}
