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

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Ferreteria
        {
            public int idProducto { get; set; }
            public string producto { get; set; }
            public string precio { get; set; }
            public string cantidad { get; set; }

            public Ferreteria() { }

            public Ferreteria(int idProducto, string producto, string precio, string cantidad)
            {
                this.idProducto = idProducto;
                this.producto = producto;
                this.precio = precio;
                this.cantidad = cantidad;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class gdb
        {
            public static int guardar(Ferreteria ferreteria)
            {
                int retorna = 0;

                using (SqlConnection conexiondgv = Conexion.SQLConexion())
                {
                    string query = "insert into productos values('" + ferreteria.producto + "', '" + ferreteria.precio + "', '" + ferreteria.cantidad + "')";
                    SqlCommand comando = new SqlCommand(query, conexiondgv);
                    comando.Parameters.AddWithValue("@producto", ferreteria.producto);
                    comando.Parameters.AddWithValue("@precio", ferreteria.precio);
                    comando.Parameters.AddWithValue("@cantidad", ferreteria.cantidad);

                    retorna = comando.ExecuteNonQuery();
                }
                return retorna;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            string precio = txtPrecio.Text;
            string cantidad = txtCantidad.Text;

            Ferreteria nuevoProducto = new Ferreteria(0, producto, precio, cantidad);

            int listaProductos = gdb.guardar(nuevoProducto);


            mostrar();
        }

        private void mostrar()
        {
            lstLista.Items.Clear();

            using (SqlConnection conexion = Conexion.SQLConexion())
            {
                string query = "SELECT idProducto, producto, precio, cantidad FROM productos";
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string idProducto = reader["idProducto"].ToString();
                        string producto = reader["producto"].ToString();
                        string precio = reader["precio"].ToString();
                        string cantidad = reader["cantidad"].ToString();

                        lstLista.Items.Add($"IdProducto: {idProducto}, Producto: {producto}, Precio: {precio}, Cantidad: {cantidad}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
