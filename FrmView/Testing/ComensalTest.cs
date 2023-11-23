using Entidades.Enumerados;
using Entidades.MetodosDeExtension;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestClass]
    public class ComensalTest
    {
        /// <summary>
        /// Metodo para 
        /// </summary>
        [TestMethod]
        public void Test_Validar_Que_Reciba_Valores_Nulos()
        {
            Comensal comensal = new Comensal();

            Assert.IsNotNull(comensal);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Test_Para_Instacias_Con_Parametros()
        {
            string nombre = "John Doe";
            int dni = 12345678;
            int cantComensales = 4;
            DateTime horario = DateTime.Parse("11:00");

            Comensal comensal = new Comensal(nombre, dni, cantComensales, horario);

            Assert.IsNotNull(comensal);
            Assert.AreEqual(nombre, comensal.Nombre);
            Assert.AreEqual(dni, comensal.Dni);
            Assert.AreEqual(cantComensales, comensal.CantComensales);
            Assert.AreEqual(horario, comensal.Horario);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Test_Para_Recuperar_Los_Datos_Instanciados()
        {
            Comensal comensal = new Comensal();

            comensal.IdComensal = 1;
            comensal.Nombre = "John Doe";
            comensal.Dni = 12345678;
            comensal.CantComensales = 4;
            comensal.NumeroMesa = 5;
            comensal.Horario = DateTime.Parse("11:00");

            Assert.AreEqual(1, comensal.IdComensal);
            Assert.AreEqual("John Doe", comensal.Nombre);
            Assert.AreEqual(12345678, comensal.Dni);
            Assert.AreEqual(4, comensal.CantComensales);
            Assert.AreEqual(5, comensal.NumeroMesa);
            Assert.AreEqual(DateTime.Parse("11:00"), comensal.Horario);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Test_Validar_Que_El_IdComensal_No_Sea_Negativo()
        {
            Comensal comensal = new Comensal();

            comensal.IdComensal = -1;

            Assert.AreEqual(0, comensal.IdComensal);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Test_Validar_Que_El_Dni_No_Sea_Negativo()
        {
            Comensal comensal = new Comensal();

            comensal.Dni = -12345678;

            Assert.AreEqual(0, comensal.Dni);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Test_Asignar_Mesa_Aleatoria()
        {
            // Arrange
            var random = new Random();

            // Act
            var mesasAsignadas = random.AsignarMesaAleatoria();

            // Assert
            Assert.IsNotNull(mesasAsignadas);
            Assert.IsTrue(mesasAsignadas.Count > 0);
            
            foreach (var mesa in mesasAsignadas)
            {
                Assert.IsTrue(Enum.IsDefined(typeof(EMesas), mesa));
            }
        }
    }
}
