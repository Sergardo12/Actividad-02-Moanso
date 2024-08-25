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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-12S2Q56; database=empresa;integrated security=true");

        public void llenar_tabla()
        {
            string consulta = "select * from cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void limpiar_campos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta = "select * from cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into cliente values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro agregado");
            llenar_tabla();
            limpiar_campos();

            conexion.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "update cliente set codigo=" + textBox1.Text + ",nombre='" + textBox2.Text + "',apellido='" + textBox3.Text + "',direccion= '" + textBox4.Text + "' where codigo=" + textBox1.Text + " ";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro modificado");
            }
            llenar_tabla();
            limpiar_campos();

            conexion.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "delete from cliente where codigo= " + textBox1.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            llenar_tabla();
            limpiar_campos();

            conexion.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
    }
}
