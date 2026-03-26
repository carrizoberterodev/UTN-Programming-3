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

        private void FormEjercicio3_Load(object sender, EventArgs e)
        {
            string[] items =
            {
                "Data Entry",
                "Operador de PC",
                "Programador",
                "Reparador de PC",
                "Tester"
            };

            clbOficio.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string salida;

            salida = "Usted selecciono los siguientes elementos: " + "\r\n";
            salida += "Sexo: " + (rBtnFemenino.Checked ? "Masculino" : "Femenino") + "\r\n";
        }
    }
}
