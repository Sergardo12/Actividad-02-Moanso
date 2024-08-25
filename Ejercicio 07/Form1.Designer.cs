namespace UPNAlumnosApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Label lblAlumnos;
        private ComboBox cmbAlumnos;
        private Button btnConsultarPromedio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.btnConsultarPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(12, 15);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(111, 13);
            this.lblAlumnos.TabIndex = 0;
            this.lblAlumnos.Text = "Seleccione un alumno:";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(129, 12);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(143, 21);
            this.cmbAlumnos.TabIndex = 1;
            // 
            // btnConsultarPromedio
            // 
            this.btnConsultarPromedio.Location = new System.Drawing.Point(15, 48);
            this.btnConsultarPromedio.Name = "btnConsultarPromedio";
            this.btnConsultarPromedio.Size = new System.Drawing.Size(257, 23);
            this.btnConsultarPromedio.TabIndex = 2;
            this.btnConsultarPromedio.Text = "Consultar Promedio";
            this.btnConsultarPromedio.UseVisualStyleBackColor = true;
            this.btnConsultarPromedio.Click += new System.EventHandler(this.btnConsultarPromedio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnConsultarPromedio);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.lblAlumnos);
            this.Name = "Form1";
            this.Text = "Consulta de Promedios - UPN";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
