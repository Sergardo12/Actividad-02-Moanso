using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Conexion
    {
        public static SqlConnection SQLConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-T5N3M8LK;Initial Catalog=empresa;Integrated Security=True");
            conexion.Open();
            return conexion;
        }

    }
}
