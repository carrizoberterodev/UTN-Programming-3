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
    public partial class FormEjercicio2 : Form
    {
        FormularioPrincipal fPrincipal;
        public FormEjercicio2(FormularioPrincipal fPlocal)
        {
            InitializeComponent();
            fPrincipal = fPlocal;
        }

        private void FormEjercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fPrincipal.Show();
        }

        private void btnAgregarEj2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNombreEj2.Text))
            {
                MessageBox.Show("Complete el campo Nombre.", "Advertencia");
                tbxNombreEj2.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbxApellidoEj2.Text))
                {
                    MessageBox.Show("Complete el campo Apellido.", "Advertencia");
                    tbxApellidoEj2.BackColor = System.Drawing.Color.OrangeRed;
                }
                else
                {
                    ///Ya esta hecha la validacion aca.
                    tbxNombreEj2.BackColor = SystemColors.Window;
                    tbxApellidoEj2.BackColor = SystemColors.Window;
                    MessageBox.Show("OK");
                }
            }
        }
    }
}
