using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsultaPromediosUPN
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar los promedios de los alumnos por curso
        private Dictionary<string, Dictionary<string, int>> promediosPorCurso;

        public Form1()
        {
            InitializeComponent();

            // Inicializar el diccionario
            promediosPorCurso = new Dictionary<string, Dictionary<string, int>>();

            // Simular la carga de datos desde la base de datos
            CargarDatosDesdeBaseDeDatos();

            // Añadir los nombres de los cursos al ComboBox de cursos
            foreach (var curso in promediosPorCurso.Keys)
            {
                cmbCursos.Items.Add(curso);
            }

            cmbCursos.SelectedIndex = 0; // Seleccionar la primera opción por defecto
        }

        private void CargarDatosDesdeBaseDeDatos()
        {
            // Lista de 40 alumnos con nombres no genéricos
            string[] alumnos = {
                "Sergio Shark", "Eduardo Lujan", "Akanita", "Alfarius Top", "Jurjen Vargas", "Angelo Lujan",
                "Gustavo Huamán", "Luna Estrada", "Valeria Torres", "Carlos Smith", "Paola Miranda",
                "Felipe Alvarado", "Marina Gamboa", "Santiago Ramírez", "Andrés Pérez", "Esteban Cortázar",
                "Natalia Velásquez", "Liliana Ríos", "Renzo Pacheco", "Mónica Quiñones", "Raúl Campos",
                "Valentina Rosales", "Bruno Delgado", "Isabela Montoya", "Fernando Gutiérrez",
                "Iván Ramírez", "Carmen Mejía", "Ricardo Zapata", "Diana Flores", "Sebastián Cabrera",
                "Gabriela Núñez", "Leonardo Marín", "Laura Sánchez", "Diego Benítez", "Patricia León",
                "Francisco Torres", "Emilia Vargas", "Miguel López", "Jazmín Arévalo", "Claudia Rojas"
            };

            Random random = new Random();

            // Crear los promedios para cada curso
            promediosPorCurso["Moanso"] = new Dictionary<string, int>();
            promediosPorCurso["Electrónica Digital"] = new Dictionary<string, int>();
            promediosPorCurso["Computación Gráfica"] = new Dictionary<string, int>();
            promediosPorCurso["Base de Datos"] = new Dictionary<string, int>();
            promediosPorCurso["Big Data"] = new Dictionary<string, int>();

            // Rellenar los promedios para cada alumno en cada curso
            foreach (var alumno in alumnos)
            {
                foreach (var curso in promediosPorCurso.Keys)
                {
                    int promedio = random.Next(0, 21); // Generar un promedio aleatorio entre 0 y 20
                    promediosPorCurso[curso].Add(alumno, promedio);
                }
            }

            // Asegurarse de que al menos dos alumnos estén desaprobados (promedio menor a 11)
            promediosPorCurso["Moanso"]["Sergio Shark"] = 8; // Desaprobado
            promediosPorCurso["Electrónica Digital"]["Eduardo Lujan"] = 9; // Desaprobado
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ComboBox de alumnos
            cmbAlumnos.Items.Clear();

            // Obtener el curso seleccionado
            string cursoSeleccionado = cmbCursos.SelectedItem.ToString();

            // Añadir los nombres de los alumnos del curso seleccionado al ComboBox de alumnos
            foreach (var alumno in promediosPorCurso[cursoSeleccionado].Keys)
            {
                cmbAlumnos.Items.Add(alumno);
            }

            cmbAlumnos.SelectedIndex = 0; // Seleccionar la primera opción por defecto
        }

        private void btnConsultarPromedio_Click(object sender, EventArgs e)
        {
            // Obtener el curso y el nombre del alumno seleccionado
            string cursoSeleccionado = cmbCursos.SelectedItem.ToString();
            string alumnoSeleccionado = cmbAlumnos.SelectedItem.ToString();

            // Obtener el promedio del alumno seleccionado
            int promedio = promediosPorCurso[cursoSeleccionado][alumnoSeleccionado];

            // Mostrar el promedio en el TextBox
            txtPromedio.Text = promedio.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

