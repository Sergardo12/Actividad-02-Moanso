namespace Ejercicio_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEnviar = new Button();
            label1 = new Label();
            label2 = new Label();
            cbxTérminos = new CheckBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(361, 257);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 22);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 63);
            label1.Name = "label1";
            label1.Size = new Size(633, 84);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(105, 18);
            label2.Name = "label2";
            label2.Size = new Size(522, 25);
            label2.TabIndex = 2;
            label2.Text = "Aceptación de Términos para el taller de desarrollo personal.\r\n";
            // 
            // cbxTérminos
            // 
            cbxTérminos.AutoSize = true;
            cbxTérminos.Location = new Point(234, 260);
            cbxTérminos.Margin = new Padding(3, 2, 3, 2);
            cbxTérminos.Name = "cbxTérminos";
            cbxTérminos.Size = new Size(117, 19);
            cbxTérminos.TabIndex = 3;
            cbxTérminos.Text = "Aceptar términos";
            cbxTérminos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 210);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre del participante: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 210);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 212);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo: ";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(502, 210);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(179, 23);
            txtCorreo.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 338);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(cbxTérminos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Label label1;
        private Label label2;
        private CheckBox cbxTérminos;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtCorreo;
    }
}
