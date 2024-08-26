using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InscripcionTalleres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Llenar el ComboBox con los talleres disponibles
            comboBoxTalleres.Items.Add("Fútbol");
            comboBoxTalleres.Items.Add("Básquet");
            comboBoxTalleres.Items.Add("Natación");
            comboBoxTalleres.Items.Add("Vóley");
            comboBoxTalleres.Items.Add("Taekwondo");
            comboBoxTalleres.Items.Add("Música");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string codigo = textBoxCodigo.Text;
            string taller = comboBoxTalleres.SelectedItem?.ToString();

            // Validar que el nombre contenga solo letras
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación
            MessageBox.Show($"Inscripción exitosa:\nNombre: {nombre}\nCódigo: {codigo}\nTaller: {taller}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos
            textBoxNombre.Clear();
            textBoxCodigo.Clear();
            comboBoxTalleres.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

