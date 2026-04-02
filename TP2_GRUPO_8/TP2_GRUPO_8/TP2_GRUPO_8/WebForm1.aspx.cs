using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP2_GRUPO_8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            txtProd1.BackColor = CampoValido(txtProd1) ? SystemColors.Window : System.Drawing.Color.Red;
            txtCantidad1.BackColor = CampoValido(txtCantidad1) ? SystemColors.Window : System.Drawing.Color.Red;
            txtProd2.BackColor = CampoValido(txtProd2) ? SystemColors.Window : System.Drawing.Color.Red;
            txtCantidad2.BackColor = CampoValido(txtCantidad2) ? SystemColors.Window : System.Drawing.Color.Red;
            if (CampoValido(txtProd1) && CampoValido(txtCantidad1) && CampoValido(txtProd2) && CampoValido(txtCantidad2))
            {

                lblError.ForeColor = System.Drawing.Color.Black;
                lblError.Text = "";
                ///Validado. Aca escribir el codigo
            }
            else
            {   
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = "Debe completar todos los campos.";
            }
        }

        private bool validarCampos()
        {
            if ((string.IsNullOrWhiteSpace(txtProd1.Text) || string.IsNullOrWhiteSpace(txtProd2.Text))
                || (string.IsNullOrWhiteSpace(txtCantidad1.Text) || string.IsNullOrWhiteSpace(txtCantidad2.Text)))
            {
                return true;
            }
            return false;
        }

        private bool CampoValido(TextBox txbValidar)
        {
            return !string.IsNullOrWhiteSpace(txbValidar.Text);
        }

    }
}