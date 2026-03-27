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
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string salida;

            salida = "Usted selecciono los siguientes elementos: " + "\r\n";
            salida += "Sexo: " + (rBtnFemenino.Checked ? "Femenino" : "Masculino") + "\r\n";

            salida += "Estado civil: " + (rBtnCasado.Checked ? "Casado" : "Soltero" + "\r\n");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine($"Oficio:");
            foreach (var oficio in clbOficio.CheckedItems) {
                sb.AppendLine($"- {oficio}");
            }



            lblTexto.Text = salida + sb ;
        }
    }
}
