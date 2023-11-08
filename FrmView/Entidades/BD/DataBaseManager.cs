using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.Interfaces;
using Entidades.Archivo;

namespace Entidades.BD
{
    public class DataBaseManager
    {
        /// <summary>
        /// Declaracion de atributo estatico
        /// </summary>
        private static string stringConnection;

        /// <summary>
        /// Constructor statico
        /// </summary>
        /// <exception cref="ExcepcionesBD"></exception>
        static DataBaseManager()
        {
            try
            {
                DataBaseManager.stringConnection = "Server=.;Database=RESERVAS_TP;Trusted_Connection=True;";
            }
            catch (Exception ex)
            {
                throw new ExcepcionesBD("¡Error al conectarse a la base de datos!");
            }
        }

        /// <summary>
        /// Metodo estatico para Guardar Nueva Reserva
        /// </summary>
        /// <param name="comensal">Recibe como parametro un comensal</param>
        /// <returns>Retorna un true si se puedo guardar la nueva reserva</returns>
        /// <exception cref="ExcepcionesBD">Excepcion controlada</exception>
        public static bool GuardarNuevaReserva(Comensal comensal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseManager.stringConnection))
                {

                    string querry = "INSERT INTO Lista_Reservas (nombre,dni,cantComensales,horaReserva) VALUES (@Nombre,@Dni,@CantComensales,@HoraReserva)";
                    
                    SqlCommand cmd = new SqlCommand(querry, connection);

                    cmd.Parameters.AddWithValue("nombre", comensal.Nombre);
                    cmd.Parameters.AddWithValue("dni", comensal.Dni);
                    cmd.Parameters.AddWithValue("cantComensales", comensal.CantComensales);
                    cmd.Parameters.AddWithValue("horaReserva", comensal.Horario);

                    connection.Open();

                    cmd.ExecuteNonQuery();

                    return true;
            
                }

            }
            catch (ExcepcionesBD ex)
            {
                throw new ExcepcionesBD("Error al guardar en la base de dato", ex);

                FileManager.Guardar(ex.Message, "ErrorAlGuardarEnBD.txt", false);
            }
        }

        /// <summary>
        /// Metodo estatico para buscar por dni en la base de dato
        /// </summary>
        /// <param name="dni">Recibe un dni</param>
        /// <returns></returns>
        /// <exception cref="ExcepcionesBD">Excepcion controlada</exception>
        public static Comensal BuscarReservaPorDni(int dni)
        {
            List<Comensal> comensals = DataBaseManager.ObtenerListaDeReserva();

            foreach (Comensal item in comensals)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }

            throw new ExcepcionesBD("Ningun elemento para ese DNI");
        }

        /// <summary>
        /// Metodo statico para eleminar una reserva atraves del dni
        /// </summary>
        /// <param name="dni">Recibe un dni</param>
        /// <returns></returns>
        /// <exception cref="ExcepcionesBD">Excepcion controlada</exception>
        public static bool EliminarReservaPorDni(int dni)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string querry = "DELETE FROM Lista_Reservas WHERE dni=@Dni";

                    SqlCommand cmd = new SqlCommand(querry, connection);

                    cmd.Parameters.AddWithValue("dni", dni);
                    
                    connection.Open();

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (ExcepcionesBD ex)
            {
                throw new ExcepcionesBD("Error al eliminar la reserva", ex);
            }
        }

        /// <summary>
        /// Metodo estatico para obtener la lista de reservas
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExcepcionesBD"></exception>
        public static List<Comensal> ObtenerListaDeReserva()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    List<Comensal> listComensal = new List<Comensal>();
                    
                    string querry = "SELECT * FROM Lista_Reservas";
                    
                    SqlCommand cmd = new SqlCommand(querry, connection);
                    
                    connection.Open();
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Comensal comensal = new Comensal();

                            comensal.IdComensal = reader.GetInt32(0);
                            comensal.Nombre = reader.GetString(1);  
                            comensal.Dni = reader.GetInt32(2);
                            comensal.CantComensales = reader.GetInt32(3);
                            comensal.Horario = reader.GetDateTime(4);

                            listComensal.Add(comensal);
                        }

                        return listComensal;

                        FileManager.Guardar(listComensal.ToString(), "Reservas.txt", true);
                    }
                    else
                    {
                        throw new ExcepcionesBD("No hay reservar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ExcepcionesBD("Error al obtener la lista de reservas", ex);
            }
        }
    }
}
