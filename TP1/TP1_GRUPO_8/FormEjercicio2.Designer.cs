namespace TP1_GRUPO_8
{
    partial class FormEjercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxIngresodeDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregarEj2 = new System.Windows.Forms.Button();
            this.tbxApellidoEj2 = new System.Windows.Forms.TextBox();
            this.tbxNombreEj2 = new System.Windows.Forms.TextBox();
            this.lblApellidoEj2 = new System.Windows.Forms.Label();
            this.lblNombreEj2 = new System.Windows.Forms.Label();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.lbElementosEj2 = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbxIngresodeDatos.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIngresodeDatos
            // 
            this.gbxIngresodeDatos.Controls.Add(this.btnAgregarEj2);
            this.gbxIngresodeDatos.Controls.Add(this.tbxApellidoEj2);
            this.gbxIngresodeDatos.Controls.Add(this.tbxNombreEj2);
            this.gbxIngresodeDatos.Controls.Add(this.lblApellidoEj2);
            this.gbxIngresodeDatos.Controls.Add(this.lblNombreEj2);
            this.gbxIngresodeDatos.Location = new System.Drawing.Point(16, 15);
            this.gbxIngresodeDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxIngresodeDatos.Name = "gbxIngresodeDatos";
            this.gbxIngresodeDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxIngresodeDatos.Size = new System.Drawing.Size(517, 524);
            this.gbxIngresodeDatos.TabIndex = 0;
            this.gbxIngresodeDatos.TabStop = false;
            this.gbxIngresodeDatos.Text = "Ingreso de Datos";
            // 
            // btnAgregarEj2
            // 
            this.btnAgregarEj2.Location = new System.Drawing.Point(188, 327);
            this.btnAgregarEj2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEj2.Name = "btnAgregarEj2";
            this.btnAgregarEj2.Size = new System.Drawing.Size(137, 48);
            this.btnAgregarEj2.TabIndex = 4;
            this.btnAgregarEj2.Text = "Agregar";
            this.btnAgregarEj2.UseVisualStyleBackColor = true;
            this.btnAgregarEj2.Click += new System.EventHandler(this.btnAgregarEj2_Click);
            // 
            // tbxApellidoEj2
            // 
            this.tbxApellidoEj2.Location = new System.Drawing.Point(140, 260);
            this.tbxApellidoEj2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxApellidoEj2.Name = "tbxApellidoEj2";
            this.tbxApellidoEj2.Size = new System.Drawing.Size(235, 22);
            this.tbxApellidoEj2.TabIndex = 3;
            // 
            // tbxNombreEj2
            // 
            this.tbxNombreEj2.Location = new System.Drawing.Point(140, 226);
            this.tbxNombreEj2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNombreEj2.Name = "tbxNombreEj2";
            this.tbxNombreEj2.Size = new System.Drawing.Size(235, 22);
            this.tbxNombreEj2.TabIndex = 2;
            // 
            // lblApellidoEj2
            // 
            this.lblApellidoEj2.AutoSize = true;
            this.lblApellidoEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEj2.Location = new System.Drawing.Point(9, 256);
            this.lblApellidoEj2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoEj2.Name = "lblApellidoEj2";
            this.lblApellidoEj2.Size = new System.Drawing.Size(117, 29);
            this.lblApellidoEj2.TabIndex = 1;
            this.lblApellidoEj2.Text = "Apellido:";
            // 
            // lblNombreEj2
            // 
            this.lblNombreEj2.AutoSize = true;
            this.lblNombreEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEj2.Location = new System.Drawing.Point(9, 223);
            this.lblNombreEj2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEj2.Name = "lblNombreEj2";
            this.lblNombreEj2.Size = new System.Drawing.Size(114, 29);
            this.lblNombreEj2.TabIndex = 0;
            this.lblNombreEj2.Text = "Nombre:";
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.btnBorrar);
            this.gbElementos.Controls.Add(this.lbElementosEj2);
            this.gbElementos.Location = new System.Drawing.Point(639, 15);
            this.gbElementos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbElementos.Size = new System.Drawing.Size(412, 524);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // lbElementosEj2
            // 
            this.lbElementosEj2.FormattingEnabled = true;
            this.lbElementosEj2.ItemHeight = 16;
            this.lbElementosEj2.Location = new System.Drawing.Point(40, 38);
            this.lbElementosEj2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbElementosEj2.Name = "lbElementosEj2";
            this.lbElementosEj2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbElementosEj2.Size = new System.Drawing.Size(335, 404);
            this.lbElementosEj2.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBorrar.Location = new System.Drawing.Point(151, 449);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(108, 48);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbxIngresodeDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre y Apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio2_FormClosed);
            this.gbxIngresodeDatos.ResumeLayout(false);
            this.gbxIngresodeDatos.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIngresodeDatos;
        private System.Windows.Forms.TextBox tbxApellidoEj2;
        private System.Windows.Forms.TextBox tbxNombreEj2;
        private System.Windows.Forms.Label lblApellidoEj2;
        private System.Windows.Forms.Label lblNombreEj2;
        private System.Windows.Forms.Button btnAgregarEj2;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.ListBox lbElementosEj2;
        private System.Windows.Forms.Button btnBorrar;
    }
}