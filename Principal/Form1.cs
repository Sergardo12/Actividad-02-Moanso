using Ejercicio02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjer01_Click(object sender, EventArgs e)
        {
            Ejercicio01CBX.Form1 ejercicio01 = new Ejercicio01CBX.Form1();
            ejercicio01.ShowDialog();
        }
        private void btnEjer02_Click(object sender, EventArgs e)
        {
            Ejercicio2.Form1 ejercicio02 = new Ejercicio2.Form1();
            ejercicio02.ShowDialog();
        }

        private void btnEjer03_Click(object sender, EventArgs e)
        {
            Ejercicio03.CXB ejercicio03 = new Ejercicio03.CXB();
            ejercicio03.ShowDialog();
        }

        private void btnEjer04_Click(object sender, EventArgs e)
        {
            Ejercicio04RB.Form1 ejercicio04 = new Ejercicio04RB.Form1();
            ejercicio04.ShowDialog();
        }

        private void btnEjer05_Click(object sender, EventArgs e)
        {
            Ejercicio02.Ejercicio05 ejercicio05 = new Ejercicio02.Ejercicio05();
            ejercicio05.ShowDialog();
        }
        private void btnEjer06_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form1 ejercicio06 = new WindowsFormsApp1.Form1();
            ejercicio06.ShowDialog();
        }

        private void btnEjer07_Click(object sender, EventArgs e)
        {
            Ejercicio07cbx.Form1 ejercicio07 = new Ejercicio07cbx.Form1();
            ejercicio07.ShowDialog();
        }

        private void btnEjer08_Click(object sender, EventArgs e)
        {
            Ejercicio_08.Form1 ejercicio08 = new Ejercicio_08.Form1();
            ejercicio08.ShowDialog();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
