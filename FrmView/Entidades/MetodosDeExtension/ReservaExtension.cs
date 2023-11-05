using Entidades.Enumerados;
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
        //public static double CalcularCostoReserva(this List<Comensal> comensal, int costoInicial) 
        //{
        //    clientes.ForEach(cliente => costoInicial += (costoInicial) * ((int)cliente.CantComensales / 100));
        //    return costoInicial;
        //}

        public static List<EMesas> AsignarMesaAleatoria(this Random random)
        {
            List<EMesas> reservas = new List<EMesas>()
            {
                EMesas.Mesa1,
                EMesas.Mesa2,
                EMesas.Mesa3,
                EMesas.Mesa4,
            };

            int cant = random.Next(1, reservas.Count + 1);

            return reservas.Take(cant).ToList();
        }
    }
}
