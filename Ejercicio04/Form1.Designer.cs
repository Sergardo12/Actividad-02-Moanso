namespace Ejercicio04
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEnviar = new Button();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDNI = new TextBox();
            rbtnPesima = new RadioButton();
            rbtnNormal = new RadioButton();
            rbtnBuena = new RadioButton();
            rbtnMuyBuena = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(284, 38);
            label1.Name = "label1";
            label1.Size = new Size(337, 41);
            label1.TabIndex = 0;
            label1.Text = "Encuesta de satisfacción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 122);
            label2.Name = "label2";
            label2.Size = new Size(895, 140);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 337);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre: ";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(355, 453);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(155, 48);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 334);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 27);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 337);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 5;
            label4.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(493, 334);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(221, 27);
            txtDNI.TabIndex = 6;
            // 
            // rbtnPesima
            // 
            rbtnPesima.AutoSize = true;
            rbtnPesima.Location = new Point(166, 397);
            rbtnPesima.Name = "rbtnPesima";
            rbtnPesima.Size = new Size(76, 24);
            rbtnPesima.TabIndex = 7;
            rbtnPesima.TabStop = true;
            rbtnPesima.Text = "Pésima";
            rbtnPesima.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            rbtnNormal.AutoSize = true;
            rbtnNormal.Location = new Point(318, 397);
            rbtnNormal.Name = "rbtnNormal";
            rbtnNormal.Size = new Size(80, 24);
            rbtnNormal.TabIndex = 8;
            rbtnNormal.TabStop = true;
            rbtnNormal.Text = "Normal";
            rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // rbtnBuena
            // 
            rbtnBuena.AutoSize = true;
            rbtnBuena.Location = new Point(459, 397);
            rbtnBuena.Name = "rbtnBuena";
            rbtnBuena.Size = new Size(71, 24);
            rbtnBuena.TabIndex = 9;
            rbtnBuena.TabStop = true;
            rbtnBuena.Text = "Buena";
            rbtnBuena.UseVisualStyleBackColor = true;
            // 
            // rbtnMuyBuena
            // 
            rbtnMuyBuena.AutoSize = true;
            rbtnMuyBuena.Location = new Point(581, 397);
            rbtnMuyBuena.Name = "rbtnMuyBuena";
            rbtnMuyBuena.Size = new Size(103, 24);
            rbtnMuyBuena.TabIndex = 10;
            rbtnMuyBuena.TabStop = true;
            rbtnMuyBuena.Text = "Muy buena";
            rbtnMuyBuena.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 568);
            Controls.Add(rbtnMuyBuena);
            Controls.Add(rbtnBuena);
            Controls.Add(rbtnNormal);
            Controls.Add(rbtnPesima);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(btnEnviar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEnviar;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDNI;
        private RadioButton rbtnPesima;
        private RadioButton rbtnNormal;
        private RadioButton rbtnBuena;
        private RadioButton rbtnMuyBuena;
    }
}
