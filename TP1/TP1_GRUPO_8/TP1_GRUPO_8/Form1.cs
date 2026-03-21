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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            ///Creo una instancia de Form2Ej1 y le paso el formulario principal para que pueda volver a mostrarlo cuando se cierre el formulario 2
            Form2Ej1 f2Local = new Form2Ej1(this);
            f2Local.Show();

            this.Hide();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
