using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Ejercicio05 : Form
    {
        public Ejercicio05()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            string connectionString = "Server=DESKTOP-12S2Q56;Database=empresa;Trusted_Connection=True;";

            
            string query = "SELECT Codigo, Nombre, Apellido, Direccion FROM cliente";

         
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                 
                    TreeNode clientNode = new TreeNode($"Cliente {reader["Codigo"]}");

                 
                    clientNode.Nodes.Add($"Nombre: {reader["Nombre"]}");
                    clientNode.Nodes.Add($"Apellido: {reader["Apellido"]}");
                    clientNode.Nodes.Add($"Dirección: {reader["Direccion"]}");

                    treeView1.Nodes.Add(clientNode);
                }

                reader.Close();
            }
        }

    }
}
