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
                    string nombreCompleto = tbxNombreEj2.Text + " " + tbxApellidoEj2.Text;

                    for(int i = 0; i < lbElementosEj2.Items.Count; i++)
                    {
                        if (lbElementosEj2.Items[i].ToString().ToUpper() == nombreCompleto.ToUpper())
                        {
                            MessageBox.Show("El nombre ya existe en la lista.", "Advertencia");

                            tbxApellidoEj2.Clear();
                            tbxNombreEj2.Clear();

                            return;
                        }
                    }


                    ///Ya esta hecha la validacion aca.
                    tbxNombreEj2.BackColor = SystemColors.Window;
                    tbxApellidoEj2.BackColor = SystemColors.Window;

                    lbElementosEj2.Items.Add(tbxNombreEj2.Text + " " + tbxApellidoEj2.Text);

                    tbxApellidoEj2.Clear();
                    tbxNombreEj2.Clear();


                    MessageBox.Show("Nombres Agregados", "Exito");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbElementosEj2.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un elemento para borrar.", "Advertencia");
                return;
            }

            lbElementosEj2.Items.Remove(lbElementosEj2.SelectedItem);
        }
    }
}
