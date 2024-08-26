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
                // Validar DNI (aquí se puede agregar una validación específica según las reglas del DNI)
                if (validarDNI(txtDNI.Text))
                {
                    // Verificar que se haya seleccionado un nivel de satisfacción
                    if (rbtnPesima.Checked || rbtnNormal.Checked || rbtnBuena.Checked || rbtnMuyBuena.Checked)
                    {
                        // Obtener el nivel de satisfacción seleccionado
                        string satisfaccion = "";
                        if (rbtnMuyBuena.Checked) satisfaccion = "Muy Bueno";
                        else if (rbtnBuena.Checked) satisfaccion = "Buena";
                        else if (rbtnNormal.Checked) satisfaccion = "Normal";
                        else if (rbtnPesima.Checked) satisfaccion = "Pésima";
                    

                        // Procesar los datos de la encuesta
                        string nombre = txtNombre.Text;
                        string dni = txtDNI.Text;
                        // Código para enviar datos (ej. guardar en base de datos)

                        // Mostrar mensaje de confirmación
                        MessageBox.Show("Gracias por completar la encuesta. Su opinión es valiosa.");

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
            // Ejemplo básico de validación de DNI: comprobar que tenga 8 dígitos
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
