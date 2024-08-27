using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio2
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
