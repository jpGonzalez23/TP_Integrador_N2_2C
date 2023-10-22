using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.BD
{
    public static class BaseDeDatos
    {
        private static SqlConnection connection;
        private static string stringConnection;
    }
}
