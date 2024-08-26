namespace InscripcionTalleres
{
    partial class CBX
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelNombre = new Label();
            labelCodigo = new Label();
            labelTaller = new Label();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            comboBoxTalleres = new ComboBox();
            buttonGuardar = new Button();
            buttonLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F);
            labelNombre.Location = new Point(54, 155);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(71, 21);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 12F);
            labelCodigo.Location = new Point(54, 195);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(63, 21);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código:";
            // 
            // labelTaller
            // 
            labelTaller.AutoSize = true;
            labelTaller.Font = new Font("Segoe UI", 12F);
            labelTaller.Location = new Point(54, 235);
            labelTaller.Name = "labelTaller";
            labelTaller.Size = new Size(49, 21);
            labelTaller.TabIndex = 2;
            labelTaller.Text = "Taller:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 12F);
            textBoxNombre.Location = new Point(124, 152);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(302, 29);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Font = new Font("Segoe UI", 12F);
            textBoxCodigo.Location = new Point(124, 192);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(302, 29);
            textBoxCodigo.TabIndex = 4;
            // 
            // comboBoxTalleres
            // 
            comboBoxTalleres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTalleres.Font = new Font("Segoe UI", 12F);
            comboBoxTalleres.FormattingEnabled = true;
            comboBoxTalleres.Location = new Point(124, 235);
            comboBoxTalleres.Name = "comboBoxTalleres";
            comboBoxTalleres.Size = new Size(302, 29);
            comboBoxTalleres.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Font = new Font("Segoe UI", 12F);
            buttonGuardar.Location = new Point(98, 281);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(80, 38);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Segoe UI", 12F);
            buttonLimpiar.Location = new Point(319, 281);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(80, 38);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(112, 32);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 8;
            label1.Text = "REGISTRO DE TALLERES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 73);
            label2.Name = "label2";
            label2.Size = new Size(314, 63);
            label2.TabIndex = 9;
            label2.Text = "Crear una aplicación en Windows Form, \r\nen la que los estudiantes puedan registrarse\r\n en un taller con su nombre y código";
            label2.Click += label2_Click;
            // 
            // CBX
            // 
            ClientSize = new Size(487, 347);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonGuardar);
            Controls.Add(comboBoxTalleres);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(labelTaller);
            Controls.Add(labelCodigo);
            Controls.Add(labelNombre);
            Name = "CBX";
            Text = "Inscripción a Talleres";
            Load += CBX_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelTaller;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.ComboBox comboBoxTalleres;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private Label label1;
        private Label label2;
    }
}
