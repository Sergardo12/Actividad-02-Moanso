using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           
            if (cbxTérminos.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtCorreo.Text)) //Si esta rellenado
                {
                    if (validarCorreo(txtCorreo.Text))

                       {
                            cbxTérminos.Enabled = false;
                            // Procesar datos de registro
                            string nombre = txtNombre.Text;
                            string correo = txtCorreo.Text;
                            // Código para enviar datos
                            MessageBox.Show("Datos ingresados correctamente");
                            txtNombre.Text = "";
                            txtCorreo.Text = "";
                            cbxTérminos.Checked = false;
                            cbxTérminos.Enabled = true;
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

        private bool validarCorreo( string correo)
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
