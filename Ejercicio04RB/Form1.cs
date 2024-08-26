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

namespace Ejercicio04RB
{
    public partial class Form1 : Form
    {
        // Define la cadena de conexión a la base de datos
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-12S2Q56; database=empresa; integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                if (validarDNI(txtDNI.Text))
                {
                    if (rbtnPesima.Checked || rbtnNormal.Checked || rbtnBuena.Checked || rbtnMuyBuena.Checked)
                    {
                        string satisfaccion = "";
                        if (rbtnMuyBuena.Checked) satisfaccion = "Muy Bueno";
                        else if (rbtnBuena.Checked) satisfaccion = "Buena";
                        else if (rbtnNormal.Checked) satisfaccion = "Normal";
                        else if (rbtnPesima.Checked) satisfaccion = "Pésima";

                        string nombre = txtNombre.Text;
                        string dni = txtDNI.Text;

                        // Llama al método para guardar los datos en la base de datos
                        GuardarDatos(nombre, dni, satisfaccion);

                        MessageBox.Show("Gracias por completar la encuesta. Su opinión es valiosa.");

                        txtNombre.Text = "";
                        txtDNI.Text = "";
                        rbtnMuyBuena.Checked = false;
                        rbtnBuena.Checked = false;
                        rbtnNormal.Checked = false;
                        rbtnPesima.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un nivel de satisfacción.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un DNI válido.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar su nombre y DNI.");
            }
        }

        private bool validarDNI(string dni)
        {
            if (dni.Length == 8 && dni.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GuardarDatos(string nombre, string dni, string satisfaccion)
        {
            try
            {
                conexion.Open();

                string query = "INSERT INTO EncuestaSatisfaccion (Nombre, DNI, Satisfaccion) VALUES (@Nombre, @DNI, @Satisfaccion)";
                SqlCommand command = new SqlCommand(query, conexion);

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Satisfaccion", satisfaccion);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}