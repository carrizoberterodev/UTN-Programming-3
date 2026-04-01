using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private bool validarCampos() {
            if ((string.IsNullOrWhiteSpace(txtProd1.Text) || string.IsNullOrWhiteSpace(txtProd2.Text))
                || (string.IsNullOrWhiteSpace(txbCantidad1.Text) || string.IsNullOrWhiteSpace(txbCantidad2.Text))) {
                return true;
            }
            return false;
        }
    }
}