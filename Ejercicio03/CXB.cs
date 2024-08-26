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

namespace Ejercicio03
{
    public partial class CXB : Form
    {
        public CXB()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-12S2Q56; database=empresa; integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puedes realizar acciones necesarias al cargar el formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxTérminos.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtCorreo.Text)) // Si está rellenado
                {
                    if (validarCorreo(txtCorreo.Text))
                    {
                        cbxTérminos.Enabled = false;

                        string nombre = txtNombre.Text;
                        string correo = txtCorreo.Text;
                        bool estado = true; // Ejemplo de estado para el campo BIT

                        try
                        {
                            // Abrir conexión
                            conexion.Open();

                            // Código para enviar datos
                            string query = "INSERT INTO MiTabla1 (estado, nombre, correo) VALUES (@Estado, @Nombre, @Correo)";
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@Estado", estado);
                                cmd.Parameters.AddWithValue("@Nombre", nombre);
                                cmd.Parameters.AddWithValue("@Correo", correo);

                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Datos ingresados correctamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error al conectar con la base de datos: " + ex.Message);
                        }
                        finally
                        {
                            // Cerrar conexión y restablecer controles
                            if (conexion.State == System.Data.ConnectionState.Open)
                            {
                                conexion.Close();
                            }

                            txtNombre.Text = "";
                            txtCorreo.Text = "";
                            cbxTérminos.Checked = false;
                            cbxTérminos.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un correo válido");
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar tus datos primero");
                }
            }
            else
            {
                MessageBox.Show("Debe aceptar los términos y condiciones");
            }
        }

        private bool validarCorreo(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }
    }
}