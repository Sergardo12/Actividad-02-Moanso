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

namespace Ejercicio02
{
    public partial class Ejercicio05 : Form
    {
        private string connectionString = "Server=DESKTOP-12S2Q56;Database=empresa;Trusted_Connection=True;TrustServerCertificate=True;";
        public Ejercicio05()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        private void treeViewLibros_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnEliminarGenero_Click(object sender, EventArgs e)
        {
            if (comboBoxEliminarGeneros.SelectedItem != null)
            {
                string selectedGenre = comboBoxEliminarGeneros.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Id FROM Generos WHERE Nombre = @Nombre", conn);
                    cmd.Parameters.AddWithValue("@Nombre", selectedGenre);
                    int genreId = (int)cmd.ExecuteScalar();
                    cmd = new SqlCommand("DELETE FROM SubGeneros WHERE GeneroId = @GeneroId", conn);
                    cmd.Parameters.AddWithValue("@GeneroId", genreId);
                    cmd.ExecuteNonQuery();


                    cmd = new SqlCommand("DELETE FROM Generos WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", genreId);
                    cmd.ExecuteNonQuery();


                    LoadGenres();
                }
            }
        }
        private void LoadGenres()
        {
            treeViewLibros.Nodes.Clear();
            comboBoxConGeneros.Items.Clear();
            comboBoxEliminarGeneros.Items.Clear();
            comboBoxEliminarSubGeneros.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SELECT * FROM Generos", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TreeNode genreNode = new TreeNode(reader["Nombre"].ToString())
                    {
                        Tag = reader["Id"]
                    };

                    treeViewLibros.Nodes.Add(genreNode);
                    comboBoxConGeneros.Items.Add(reader["Nombre"].ToString());
                    comboBoxEliminarGeneros.Items.Add(reader["Nombre"].ToString());
                }

                reader.Close();

                foreach (TreeNode genreNode in treeViewLibros.Nodes)
                {
                    int genreId = (int)genreNode.Tag;

                    cmd = new SqlCommand("SELECT * FROM SubGeneros WHERE GeneroId = @GeneroId", conn);
                    cmd.Parameters.AddWithValue("@GeneroId", genreId);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TreeNode subGenreNode = new TreeNode(reader["Nombre"].ToString())
                        {
                            Tag = reader["Id"]
                        };

                        genreNode.Nodes.Add(subGenreNode);
                        comboBoxEliminarSubGeneros.Items.Add($"{subGenreNode.Text} - {genreNode.Text}");
                    }

                    reader.Close();
                }
            }
        }

        private void btnIngresarGeneros_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGenero.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Generos (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();", conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtGenero.Text);
                    int newGenreId = Convert.ToInt32(cmd.ExecuteScalar());

                    TreeNode newGenre = new TreeNode(txtGenero.Text)
                    {
                        Tag = newGenreId
                    };

                    treeViewLibros.Nodes.Add(newGenre);
                    comboBoxConGeneros.Items.Add(newGenre.Text);
                    comboBoxEliminarGeneros.Items.Add(newGenre.Text);

                    txtGenero.Clear();
                }
            }
        }

        private void btnIngresarSubGeneros_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubGenero.Text) && comboBoxConGeneros.SelectedItem != null)
            {
                string selectedGenre = comboBoxConGeneros.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Id FROM Generos WHERE Nombre = @Nombre", conn);
                    cmd.Parameters.AddWithValue("@Nombre", selectedGenre);
                    int genreId = (int)cmd.ExecuteScalar();

                    cmd = new SqlCommand("INSERT INTO SubGeneros (Nombre, GeneroId) VALUES (@Nombre, @GeneroId); SELECT SCOPE_IDENTITY();", conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtSubGenero.Text);
                    cmd.Parameters.AddWithValue("@GeneroId", genreId);
                    cmd.ExecuteNonQuery();

                    LoadGenres();
                    txtSubGenero.Clear();
                }
            }
        }

        private void btnEliminarSubGenero_Click(object sender, EventArgs e)
        {
            if (comboBoxEliminarSubGeneros.SelectedItem != null)
            {
                string selectedItem = comboBoxEliminarSubGeneros.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');
                string selectedSubGenre = parts[0].Trim();
                string selectedGenre = parts[1].Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    SqlCommand cmd = new SqlCommand("SELECT Id FROM SubGeneros WHERE Nombre = @Nombre AND GeneroId = (SELECT Id FROM Generos WHERE Nombre = @Genero)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", selectedSubGenre);
                    cmd.Parameters.AddWithValue("@Genero", selectedGenre);
                    int subGenreId = (int)cmd.ExecuteScalar();


                    cmd = new SqlCommand("DELETE FROM SubGeneros WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", subGenreId);
                    cmd.ExecuteNonQuery();

                    LoadGenres();
                }
            }
        }
    }
}
