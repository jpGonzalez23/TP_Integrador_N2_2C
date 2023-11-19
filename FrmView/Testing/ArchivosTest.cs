using Entidades.Archivo;
using Entidades.Modelos;

namespace Testing
{
    [TestClass]
    public class ArchivosTest
    {
        /// <summary>
        /// Metodo para testear la clase de archivos
        /// </summary>
        [TestMethod]
        public void Test_Validar_Que_SeGuardenReservasEnArchivos()
        {
            Comensal comensal = new Comensal("Pepe", 45467876, 3, DateTime.Now);
            string nombreArchivo = "Reserva.txt";

            FileManager.Guardar(comensal.ToString(), nombreArchivo, false);

            string ruta = Path.Combine(FileManager.Path, nombreArchivo);

            bool archivoExiste = File.Exists(ruta);

            Assert.IsTrue(archivoExiste);
        }

        [TestMethod]
        public void Test_Validar_Que_SeGuardenSerializados()
        {

        }
    }
}