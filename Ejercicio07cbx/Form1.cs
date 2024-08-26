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

namespace Ejercicio07cbx
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, int>> promediosPorCurso;
        private SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
    
            promediosPorCurso = new Dictionary<string, Dictionary<string, int>>();

         
            conexion = new SqlConnection("server=DESKTOP-12S2Q56; database=empresa;integrated security=true");

            CargarDatosDesdeBaseDeDatos();

     
            foreach (var curso in promediosPorCurso.Keys)
            {
                cmbCursos.Items.Add(curso);
            }

            cmbCursos.SelectedIndex = 0; 
        }

        private void CargarDatosDesdeBaseDeDatos()
        {
            try
            {
                conexion.Open();
                string query = "SELECT NombreCurso, NombreAlumno, Promedio FROM PromediosAlumnos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string curso = lector["NombreCurso"].ToString();
                    string alumno = lector["NombreAlumno"].ToString();
                    int promedio = Convert.ToInt32(lector["Promedio"]);

                    if (!promediosPorCurso.ContainsKey(curso))
                    {
                        promediosPorCurso[curso] = new Dictionary<string, int>();
                    }

                    promediosPorCurso[curso].Add(alumno, promedio);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void GuardarDatosEnBaseDeDatos()
        {
            try
            {
                conexion.Open();

                foreach (var curso in promediosPorCurso)
                {
                    foreach (var alumno in curso.Value)
                    {
                        string query = "INSERT INTO PromediosAlumnos (NombreCurso, NombreAlumno, Promedio) VALUES (@curso, @alumno, @promedio)";
                        SqlCommand comando = new SqlCommand(query, conexion);
                        comando.Parameters.AddWithValue("@curso", curso.Key);
                        comando.Parameters.AddWithValue("@alumno", alumno.Key);
                        comando.Parameters.AddWithValue("@promedio", alumno.Value);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            SimularDatos();
            GuardarDatosEnBaseDeDatos();
        }

        private void SimularDatos()
        {
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

            promediosPorCurso["Moanso"] = new Dictionary<string, int>();
            promediosPorCurso["Electrónica Digital"] = new Dictionary<string, int>();
            promediosPorCurso["Computación Gráfica"] = new Dictionary<string, int>();
            promediosPorCurso["Base de Datos"] = new Dictionary<string, int>();
            promediosPorCurso["Big Data"] = new Dictionary<string, int>();

            foreach (var alumno in alumnos)
            {
                foreach (var curso in promediosPorCurso.Keys)
                {
                    int promedio = random.Next(0, 21);
                    promediosPorCurso[curso].Add(alumno, promedio);
                }
            }

            promediosPorCurso["Moanso"]["Sergio Shark"] = 8;
            promediosPorCurso["Electrónica Digital"]["Eduardo Lujan"] = 9;
        }

        private void btnConsultarPromedio_Click(object sender, EventArgs e)
        {
            string cursoSeleccionado = cmbCursos.SelectedItem.ToString();
            string alumnoSeleccionado = cmbAlumnos.SelectedItem.ToString();
            int promedio = promediosPorCurso[cursoSeleccionado][alumnoSeleccionado];
            txtPromedio.Text = promedio.ToString();
        }

        private void cmbCursos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbAlumnos.Items.Clear();
            string cursoSeleccionado = cmbCursos.SelectedItem.ToString();

            foreach (var alumno in promediosPorCurso[cursoSeleccionado].Keys)
            {
                cmbAlumnos.Items.Add(alumno);
            }

            cmbAlumnos.SelectedIndex = 0;
        }
    }
}