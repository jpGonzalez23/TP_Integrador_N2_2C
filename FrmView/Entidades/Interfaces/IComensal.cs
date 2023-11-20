using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IComensal
    {
        int IdComensal { get; set; }

        int Dni {  get; set; }

        int CantComensales {  get; set; }
        
        string Nombre {  get; set; }
       
        DateTime Horario { get; set; }


        string Mostrar();

        void AsignarMesa();
    }
}
