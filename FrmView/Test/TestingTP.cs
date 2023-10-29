using Entidades.Archivo;
using Entidades.Modelos;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validar_GuardadoDeArchivo()
        {
            //
            string data = "Hola mundo";
            string nombreArchivo = "testingGuardado.txt";

            //
            FileManager.Guardar(data, nombreArchivo, false);

            //
            Assert.IsTrue(File.Exists(Path.Combine(FileManager.path, nombreArchivo)));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Validar_Serializacion()
        {
            Cliente cliente = new Cliente("Pepe", "98090332");
            string nombreArchivo = "Ejemplo.json";

            bool result = FileManager.Serializar(cliente, nombreArchivo);

            Assert.IsTrue(result);

            //File.Delete(Path.Combine(FileManager.path, nombreArchivo));

        }
    }
}