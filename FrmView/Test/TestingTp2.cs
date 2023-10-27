using Entidades.Archivo;

namespace Test
{
    [TestClass]
    public class TestingTp2
    {
        /// <summary>
        /// 
        /// </summary>
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

        }
    }
}