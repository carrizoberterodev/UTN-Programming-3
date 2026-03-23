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
    public partial class Form2Ej1 : Form
    {
        /// Copia local del formulario 1
       
        FormularioPrincipal fPrincipal;
        public Form2Ej1(FormularioPrincipal fPLocal)
        {
            InitializeComponent();
            this.fPrincipal = fPLocal;
        }
        
        /// Al cerrar el formulario 2, se muestra nuevamente el formulario 1 para que el usuario pueda elegir otro ejercicio o cerrar la aplicación
        
        private void Form2Ej1_FormClosed(object sender, FormClosedEventArgs e)
        {
            fPrincipal.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío. Por favor ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(string item in lbNombres.Items) {
            
                if(item.ToUpper() == nombre.ToUpper()) {
                    MessageBox.Show("El nombre ya existe en la lista. Por favor ingrese un nombre diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            lbNombres.Items.Add(nombre);
            txtNombre.Clear();

        }
    }
}
