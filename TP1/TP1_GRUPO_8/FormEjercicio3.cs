using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_8
{
    public partial class FormEjercicio3 : Form
    {
        FormularioPrincipal fPrincipal;
        public FormEjercicio3(FormularioPrincipal fPlocal)
        {
            InitializeComponent();
            fPrincipal = fPlocal;
        }

        private void FormEjercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            fPrincipal.Show();
        }
    }
}
