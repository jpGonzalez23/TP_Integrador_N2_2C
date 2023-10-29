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
        public static string path;

        static FileManager()
        {
            FileManager.path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Reservas Guardas\\";
            FileManager.ValidarExistenciaDeDirectorio();
        }

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

        public static bool Serializar<T>(T elementos, string nombreArchivo)
        {
            try
            {
                FileManager.Guardar(System.Text.Json.JsonSerializer.Serialize(elementos, typeof(T)), nombreArchivo, false);
                return true;
            }
            catch (Exception ex)
            {
                throw new FileManagerException("¡Error al Serializar!", ex);
            }
        }
    }
}
