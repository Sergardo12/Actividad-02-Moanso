using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio01CBX
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();

            comboBoxTalleres.Items.Add("Fútbol");
            comboBoxTalleres.Items.Add("Básquet");
            comboBoxTalleres.Items.Add("Natación");
            comboBoxTalleres.Items.Add("Vóley");
            comboBoxTalleres.Items.Add("Taekwondo");
            comboBoxTalleres.Items.Add("Música");

            conexion = new SqlConnection("server=DESKTOP-12S2Q56; database=empresa;integrated security=true");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string codigo = textBoxCodigo.Text;
            string taller = comboBoxTalleres.SelectedItem?.ToString();

            if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (taller == null)
            {
                MessageBox.Show("Debe seleccionar un taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    
            try
            {
                conexion.Open();
                string query = "INSERT INTO Inscripciones (Nombre, Codigo, Taller) VALUES (@nombre, @codigo, @taller)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@taller", taller);
                comando.ExecuteNonQuery();

                MessageBox.Show($"Inscripción exitosa:\nNombre: {nombre}\nCódigo: {codigo}\nTaller: {taller}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxCodigo.Clear();
            comboBoxTalleres.SelectedIndex = -1;
        }
    }
}