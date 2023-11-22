using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivo
{
    public static class FileManager
    {
        private static string path;

        public static string Path
        {
            get => path;
        }

        /// <summary>
        /// Constructor statico
        /// </summary>
        static FileManager()
        {
            FileManager.path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Reservas Guardas\\";
            FileManager.ValidarExistenciaDeDirectorio();
        }

        /// <summary>
        /// Metodo para validar la existencia del directorio
        /// </summary>
        /// <exception cref="FileManagerException">Genera una excepcion en caso de no existir</exception>
        private static void ValidarExistenciaDeDirectorio()
        {
            if (!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch (Exception ex)
                {
                    throw new FileManagerException("Error al crear el directorio\n", ex);
                }
            }
        }

        /// <summary>
        /// Metodo para guardar los archivos
        /// </summary>
        /// <param name="data">Datos a guardar</param>
        /// <param name="nombreArchivo">Nombre del archivo (.txt, .json)</param>
        /// <param name="append">Sobre escribe </param>
        /// <exception cref="FileManagerException">Genera una excepcion</exception>
        public static void Guardar(string data, string nombreArchivo, bool append)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo, append))
                {
                    sw.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                throw new FileManagerException("Erro al guardar un archivo de texto\n", ex);

            }
        }

        /// <summary>
        /// Metodo para serializar
        /// </summary>
        /// <typeparam name="T">Es tipo Generico</typeparam>
        /// <param name="elementos">nombre del elemento</param>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <returns></returns>
        /// <exception cref="FileManagerException">Se genera una excepcion</exception>
        public static bool Serializar<T>(T elementos, string nombreArchivo)
        {
            try
            {
                FileManager.Guardar(System.Text.Json.JsonSerializer.Serialize(elementos, typeof(T)), nombreArchivo, true);
                return true;
            }
            catch (Exception ex)
            {
                throw new FileManagerException("¡Error al Serializar!", ex);
            }
        }
    }
}
