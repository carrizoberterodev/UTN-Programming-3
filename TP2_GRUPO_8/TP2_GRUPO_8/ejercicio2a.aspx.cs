using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_8
{
    public partial class ejercicio2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            
            CambiarColorTextBox(txtNombre);
            CambiarColorTextBox(txtApellido);
            if (CampoValido(txtNombre) && CampoValido(txtApellido)) {   ///TextBox validados

                Server.Transfer("ejercicio2b.aspx");
            }
            
            
        }



        ///Metodos
        private bool CampoValido(TextBox txbValidar)
        {
            return !string.IsNullOrWhiteSpace(txbValidar.Text);
        }

        private void CambiarColorTextBox(TextBox txbValidar)
        {
            txbValidar.BackColor = CampoValido(txbValidar) ? SystemColors.Window : System.Drawing.Color.Red;
        }
    }
}