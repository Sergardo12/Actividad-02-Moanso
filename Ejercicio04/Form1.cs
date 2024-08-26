namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                // Validar DNI (aqu� se puede agregar una validaci�n espec�fica seg�n las reglas del DNI)
                if (validarDNI(txtDNI.Text))
                {
                    // Verificar que se haya seleccionado un nivel de satisfacci�n
                    if (rbtnPesima.Checked || rbtnNormal.Checked || rbtnBuena.Checked || rbtnMuyBuena.Checked)
                    {
                        // Obtener el nivel de satisfacci�n seleccionado
                        string satisfaccion = "";
                        if (rbtnMuyBuena.Checked) satisfaccion = "Muy Bueno";
                        else if (rbtnBuena.Checked) satisfaccion = "Buena";
                        else if (rbtnNormal.Checked) satisfaccion = "Normal";
                        else if (rbtnPesima.Checked) satisfaccion = "P�sima";
                    

                        // Procesar los datos de la encuesta
                        string nombre = txtNombre.Text;
                        string dni = txtDNI.Text;
                        // C�digo para enviar datos (ej. guardar en base de datos)

                        // Mostrar mensaje de confirmaci�n
                        MessageBox.Show("Gracias por completar la encuesta. Su opini�n es valiosa.");

                        // Limpiar los campos
                        txtNombre.Text = "";
                        txtDNI.Text = "";
                        rbtnMuyBuena.Checked = false;
                        rbtnBuena.Checked = false;
                        rbtnNormal.Checked = false;
                        rbtnPesima.Checked = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un nivel de satisfacci�n.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un DNI v�lido.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar su nombre y DNI.");
            }
        }
        private bool validarDNI(string dni)
        {
            // Ejemplo b�sico de validaci�n de DNI: comprobar que tenga 8 d�gitos
            if (dni.Length == 8 && dni.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
