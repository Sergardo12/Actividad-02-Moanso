namespace ConsultaPromediosUPN
{
    partial class CBX
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCursos;
        private ComboBox cmbCursos;
        private Label lblAlumnos;
        private ComboBox cmbAlumnos;
        private Label lblPromedio;
        private TextBox txtPromedio;
        private Button btnConsultarPromedio;

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
            lblCursos = new Label();
            cmbCursos = new ComboBox();
            lblAlumnos = new Label();
            cmbAlumnos = new ComboBox();
            lblPromedio = new Label();
            txtPromedio = new TextBox();
            btnConsultarPromedio = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblCursos
            // 
            lblCursos.AutoSize = true;
            lblCursos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCursos.Location = new Point(28, 178);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(127, 20);
            lblCursos.TabIndex = 0;
            lblCursos.Text = "Seleccione curso:";
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(170, 178);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(262, 23);
            cmbCursos.TabIndex = 1;
            cmbCursos.SelectedIndexChanged += cmbCursos_SelectedIndexChanged;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumnos.Location = new Point(17, 223);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(142, 20);
            lblAlumnos.TabIndex = 2;
            lblAlumnos.Text = "Seleccione alumno:";
            // 
            // cmbAlumnos
            // 
            cmbAlumnos.FormattingEnabled = true;
            cmbAlumnos.Location = new Point(170, 224);
            cmbAlumnos.Name = "cmbAlumnos";
            cmbAlumnos.Size = new Size(262, 23);
            cmbAlumnos.TabIndex = 3;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromedio.Location = new Point(39, 307);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(116, 20);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio final:";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(170, 308);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(262, 23);
            txtPromedio.TabIndex = 5;
            // 
            // btnConsultarPromedio
            // 
            btnConsultarPromedio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarPromedio.Location = new Point(103, 265);
            btnConsultarPromedio.Name = "btnConsultarPromedio";
            btnConsultarPromedio.Size = new Size(262, 28);
            btnConsultarPromedio.TabIndex = 6;
            btnConsultarPromedio.Text = "Consultar Promedio";
            btnConsultarPromedio.UseVisualStyleBackColor = true;
            btnConsultarPromedio.Click += btnConsultarPromedio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(374, 30);
            label1.TabIndex = 7;
            label1.Text = "CONSULTA DE PROMEDIOS FINALES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(468, 60);
            label2.TabIndex = 8;
            label2.Text = "Crea una aplicación en C# en la que permita a los estudiantes \r\nconsultar los promedios finales de sus diferentes cursos, recuerda\r\n usar al menos un \"Combo box\".";
            // 
            // Form1
            // 
            ClientSize = new Size(482, 358);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultarPromedio);
            Controls.Add(txtPromedio);
            Controls.Add(lblPromedio);
            Controls.Add(cmbAlumnos);
            Controls.Add(lblAlumnos);
            Controls.Add(cmbCursos);
            Controls.Add(lblCursos);
            Name = "Form1";
            Text = "Consulta de Promedios UPN";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}

