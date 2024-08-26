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
           InscripcionTalleres.Form1 form1 = new InscripcionTalleres.Form1();
        }
    }
}
