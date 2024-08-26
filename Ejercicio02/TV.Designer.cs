namespace Ejercicio02
{
    partial class Ejercicio05
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarGeneros = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarSubGenero = new System.Windows.Forms.Button();
            this.btnEliminarGenero = new System.Windows.Forms.Button();
            this.comboBoxEliminarSubGeneros = new System.Windows.Forms.ComboBox();
            this.comboBoxEliminarGeneros = new System.Windows.Forms.ComboBox();
            this.treeViewLibros = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxConGeneros = new System.Windows.Forms.ComboBox();
            this.txtSubGenero = new System.Windows.Forms.TextBox();
            this.btnIngresarSubGeneros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingrese un género";
            // 
            // btnIngresarGeneros
            // 
            this.btnIngresarGeneros.Location = new System.Drawing.Point(102, 135);
            this.btnIngresarGeneros.Name = "btnIngresarGeneros";
            this.btnIngresarGeneros.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarGeneros.TabIndex = 19;
            this.btnIngresarGeneros.Text = "Ingresar";
            this.btnIngresarGeneros.UseVisualStyleBackColor = true;
            this.btnIngresarGeneros.Click += new System.EventHandler(this.btnIngresarGeneros_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(91, 109);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(650, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "INGRESAR GÉNEROS Y SUBGÉNEROS DE LIBROS EN UNA BIBLIOTECA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Seleccione el subgénero a eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seleccione el género a eliminar";
            // 
            // btnEliminarSubGenero
            // 
            this.btnEliminarSubGenero.Location = new System.Drawing.Point(516, 396);
            this.btnEliminarSubGenero.Name = "btnEliminarSubGenero";
            this.btnEliminarSubGenero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSubGenero.TabIndex = 23;
            this.btnEliminarSubGenero.Text = "Eliminar";
            this.btnEliminarSubGenero.UseVisualStyleBackColor = true;
            this.btnEliminarSubGenero.Click += new System.EventHandler(this.btnEliminarSubGenero_Click);
            // 
            // btnEliminarGenero
            // 
            this.btnEliminarGenero.Location = new System.Drawing.Point(311, 396);
            this.btnEliminarGenero.Name = "btnEliminarGenero";
            this.btnEliminarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarGenero.TabIndex = 22;
            this.btnEliminarGenero.Text = "Eliminar";
            this.btnEliminarGenero.UseVisualStyleBackColor = true;
            this.btnEliminarGenero.Click += new System.EventHandler(this.btnEliminarGenero_Click);
            // 
            // comboBoxEliminarSubGeneros
            // 
            this.comboBoxEliminarSubGeneros.FormattingEnabled = true;
            this.comboBoxEliminarSubGeneros.Location = new System.Drawing.Point(516, 369);
            this.comboBoxEliminarSubGeneros.Name = "comboBoxEliminarSubGeneros";
            this.comboBoxEliminarSubGeneros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEliminarSubGeneros.TabIndex = 21;
            // 
            // comboBoxEliminarGeneros
            // 
            this.comboBoxEliminarGeneros.FormattingEnabled = true;
            this.comboBoxEliminarGeneros.Location = new System.Drawing.Point(311, 369);
            this.comboBoxEliminarGeneros.Name = "comboBoxEliminarGeneros";
            this.comboBoxEliminarGeneros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEliminarGeneros.TabIndex = 20;
            // 
            // treeViewLibros
            // 
            this.treeViewLibros.Location = new System.Drawing.Point(312, 65);
            this.treeViewLibros.Name = "treeViewLibros";
            this.treeViewLibros.Size = new System.Drawing.Size(406, 274);
            this.treeViewLibros.TabIndex = 17;
            this.treeViewLibros.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLibros_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxConGeneros);
            this.groupBox1.Controls.Add(this.txtSubGenero);
            this.groupBox1.Controls.Add(this.btnIngresarSubGeneros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 158);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar subgéneros en los géneros";
            // 
            // comboBoxConGeneros
            // 
            this.comboBoxConGeneros.FormattingEnabled = true;
            this.comboBoxConGeneros.Location = new System.Drawing.Point(24, 44);
            this.comboBoxConGeneros.Name = "comboBoxConGeneros";
            this.comboBoxConGeneros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConGeneros.TabIndex = 5;
            // 
            // txtSubGenero
            // 
            this.txtSubGenero.Location = new System.Drawing.Point(24, 95);
            this.txtSubGenero.Name = "txtSubGenero";
            this.txtSubGenero.Size = new System.Drawing.Size(100, 20);
            this.txtSubGenero.TabIndex = 2;
            // 
            // btnIngresarSubGeneros
            // 
            this.btnIngresarSubGeneros.Location = new System.Drawing.Point(24, 121);
            this.btnIngresarSubGeneros.Name = "btnIngresarSubGeneros";
            this.btnIngresarSubGeneros.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarSubGeneros.TabIndex = 4;
            this.btnIngresarSubGeneros.Text = "Ingresar";
            this.btnIngresarSubGeneros.UseVisualStyleBackColor = true;
            this.btnIngresarSubGeneros.Click += new System.EventHandler(this.btnIngresarSubGeneros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese el Subgénero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seleccione el género para el nuevo subgénero";
            // 
            // Ejercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarGeneros);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarSubGenero);
            this.Controls.Add(this.btnEliminarGenero);
            this.Controls.Add(this.comboBoxEliminarSubGeneros);
            this.Controls.Add(this.comboBoxEliminarGeneros);
            this.Controls.Add(this.treeViewLibros);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio05";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarGeneros;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarSubGenero;
        private System.Windows.Forms.Button btnEliminarGenero;
        private System.Windows.Forms.ComboBox comboBoxEliminarSubGeneros;
        private System.Windows.Forms.ComboBox comboBoxEliminarGeneros;
        private System.Windows.Forms.TreeView treeViewLibros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxConGeneros;
        private System.Windows.Forms.TextBox txtSubGenero;
        private System.Windows.Forms.Button btnIngresarSubGeneros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

