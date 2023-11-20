using Entidades.BD;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestClass]
    public class BDTest
    {
        [TestMethod]
        public void Test_GuardarNuevaReserva()
        {
            //Arrange
            Comensal comensal = new Comensal("John doe", 123456789, 4, DateTime.Parse("11:00"));
            
            // Act
            bool result =  DataBaseManager.GuardarNuevaReserva(comensal);

            //Assertt
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_BuscarUnaReservaPorDni()
        {
            int dni = 23467984;

            Comensal buscarComensal = DataBaseManager.BuscarReservaPorDni(dni);

            Assert.AreEqual(dni, buscarComensal.Dni);
        }

        [TestMethod]
        public void Test_ParaEliminarReservaPorDni()
        {
            int dni = 123456789;

            bool comensal = DataBaseManager.EliminarReservaPorDni(dni);

            Assert.IsTrue(comensal);
        }
    }
}
