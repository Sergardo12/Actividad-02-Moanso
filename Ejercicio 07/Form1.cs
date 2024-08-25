using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UPNAlumnosApp
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar los promedios de los alumnos
        private Dictionary<string, double> promediosAlumnos;

        public Form1()
        {
            InitializeComponent();

            // Inicializar el diccionario con los nombres de los alumnos y sus promedios
            promediosAlumnos = new Dictionary<string, double>
            {
                { "Gustavo Huamán", 7.5 },
                { "Sergio Shark", 19.2 },
                { "Jurjen Vargas", 18 },
                { "Alberto Paredes", 15 },
                { "Brenda Salazar", 19 },
                { "Carlos Rojas", 14 },
                { "Diana Gómez", 18 },
                { "Eduardo Martínez", 11 },
                { "Florencia Paz", 17 },
                { "Gabriel Torres", 6 },
                { "Helena Rivera", 16 },
                { "Iván Díaz", 13 },
                { "Jazmín Ramírez", 20 }
            };

            // Añadir los nombres de los alumnos al ComboBox
            foreach (var alumno in promediosAlumnos.Keys)
            {
                cmbAlumnos.Items.Add(alumno);
            }

            cmbAlumnos.SelectedIndex = 0; // Seleccionar la primera opción por defecto
        }

        private void btnConsultarPromedio_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del alumno seleccionado
            string alumnoSeleccionado = cmbAlumnos.SelectedItem.ToString();

            // Obtener el promedio del alumno seleccionado
            double promedio = promediosAlumnos[alumnoSeleccionado];

            // Mostrar el promedio en un mensaje
            MessageBox.Show("El promedio final de " + alumnoSeleccionado + " es: " + promedio, "Consulta de Promedio");
        }
    }
}
