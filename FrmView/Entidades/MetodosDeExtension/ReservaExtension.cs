using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosDeExtension
{
    public static class ReservaExtension
    {
        /// <summary>
        /// Metodo de extension para asignar una mesa
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public static List<EMesas> AsignarMesaAleatoria(this Random random)
        {
            List<EMesas> reservas = new List<EMesas>()
            {
                EMesas.Mesa1,
                EMesas.Mesa2,
                EMesas.Mesa3,
                EMesas.Mesa4,
                EMesas.Mesa5,
                EMesas.Mesa6,
                EMesas.Mesa7,
                EMesas.Mesa8,
                EMesas.Mesa9,
                EMesas.Mesa10
            };

            int cant = random.Next(1, reservas.Count + 1);

            return reservas.Take(cant).ToList();
        }
    }
}
