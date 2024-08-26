using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Medicamento
        {
            public int idMedicamento { get; set; }
            public string medicamento { get; set; }
            public string precioMedicamento { get; set; }
            public string cantidadMedicamento { get; set; }

            public Medicamento() { }

            public Medicamento(int idMedicamento, string medicamento, string precioMedicamento, string cantidadMedicamento)
            {
                this.idMedicamento = idMedicamento;
                this.medicamento = medicamento;
                this.precioMedicamento = precioMedicamento;
                this.cantidadMedicamento = cantidadMedicamento;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class reg
        {
            public static int guardar(Medicamento medicamento)
            {
                int retorna = 0;

                using (SqlConnection conexiondgv = Conexion.SQLConexion())
                {
                    string query = "insert into medicamentos values('" + medicamento.medicamento + "', '" + medicamento.precioMedicamento + "', '" + medicamento.cantidadMedicamento + "')";
                    SqlCommand comando = new SqlCommand(query, conexiondgv);
                    comando.Parameters.AddWithValue("@medicamento", medicamento.medicamento);
                    comando.Parameters.AddWithValue("@precioMedicamento", medicamento.precioMedicamento);
                    comando.Parameters.AddWithValue("@cantidadMedicamento", medicamento.cantidadMedicamento);

                    retorna = comando.ExecuteNonQuery();
                }
                return retorna;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string medicamento = txtMedicamento.Text;
            string precioMedicamento = txtPrecioMedicamento.Text;
            string cantidadMedicamento = txtCantidadMedicamento.Text;

            Medicamento nuevoProducto = new Medicamento(0, medicamento, precioMedicamento, cantidadMedicamento);

            int listaProductos = reg.guardar(nuevoProducto);


            mostrar();
        }
        private void mostrar()
        {
            lstMedicamentos.Items.Clear();

            using (SqlConnection conexion = Conexion.SQLConexion())
            {
                string query = "SELECT idMedicamento, medicamento, precioMedicamento, cantidadMedicamento FROM medicamentos";
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string idMedicamento = reader["idMedicamento"].ToString();
                        string medicamento = reader["medicamento"].ToString();
                        string precioMedicamento = reader["precioMedicamento"].ToString();
                        string cantidadMedicamento = reader["cantidadMedicamento"].ToString();

                        lstMedicamentos.Items.Add($"IdMedicamento: {idMedicamento}, Medicamento: {medicamento}, PrecioMedicamento: {precioMedicamento}, CantidadMedicamento: {cantidadMedicamento}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los medicamento: " + ex.Message);
                }
            }
        }

        private void lstMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
