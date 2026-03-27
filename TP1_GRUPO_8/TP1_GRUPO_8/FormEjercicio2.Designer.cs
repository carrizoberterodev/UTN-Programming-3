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
            this.lblNombreEj2 = new System.Windows.Forms.Label();
            this.lblApellidoEj2 = new System.Windows.Forms.Label();
            this.tbxNombreEj2 = new System.Windows.Forms.TextBox();
            this.tbxApellidoEj2 = new System.Windows.Forms.TextBox();
            this.btnAgregarEj2 = new System.Windows.Forms.Button();
            this.gbxIngresodeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIngresodeDatos
            // 
            this.gbxIngresodeDatos.Controls.Add(this.btnAgregarEj2);
            this.gbxIngresodeDatos.Controls.Add(this.tbxApellidoEj2);
            this.gbxIngresodeDatos.Controls.Add(this.tbxNombreEj2);
            this.gbxIngresodeDatos.Controls.Add(this.lblApellidoEj2);
            this.gbxIngresodeDatos.Controls.Add(this.lblNombreEj2);
            this.gbxIngresodeDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxIngresodeDatos.Name = "gbxIngresodeDatos";
            this.gbxIngresodeDatos.Size = new System.Drawing.Size(388, 426);
            this.gbxIngresodeDatos.TabIndex = 0;
            this.gbxIngresodeDatos.TabStop = false;
            this.gbxIngresodeDatos.Text = "Ingreso de Datos";
            // 
            // lblNombreEj2
            // 
            this.lblNombreEj2.AutoSize = true;
            this.lblNombreEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEj2.Location = new System.Drawing.Point(7, 181);
            this.lblNombreEj2.Name = "lblNombreEj2";
            this.lblNombreEj2.Size = new System.Drawing.Size(91, 24);
            this.lblNombreEj2.TabIndex = 0;
            this.lblNombreEj2.Text = "Nombre:";
            // 
            // lblApellidoEj2
            // 
            this.lblApellidoEj2.AutoSize = true;
            this.lblApellidoEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEj2.Location = new System.Drawing.Point(7, 208);
            this.lblApellidoEj2.Name = "lblApellidoEj2";
            this.lblApellidoEj2.Size = new System.Drawing.Size(93, 24);
            this.lblApellidoEj2.TabIndex = 1;
            this.lblApellidoEj2.Text = "Apellido:";
            // 
            // tbxNombreEj2
            // 
            this.tbxNombreEj2.Location = new System.Drawing.Point(105, 184);
            this.tbxNombreEj2.Name = "tbxNombreEj2";
            this.tbxNombreEj2.Size = new System.Drawing.Size(177, 20);
            this.tbxNombreEj2.TabIndex = 2;
            // 
            // tbxApellidoEj2
            // 
            this.tbxApellidoEj2.Location = new System.Drawing.Point(105, 211);
            this.tbxApellidoEj2.Name = "tbxApellidoEj2";
            this.tbxApellidoEj2.Size = new System.Drawing.Size(177, 20);
            this.tbxApellidoEj2.TabIndex = 3;
            // 
            // btnAgregarEj2
            // 
            this.btnAgregarEj2.Location = new System.Drawing.Point(141, 266);
            this.btnAgregarEj2.Name = "btnAgregarEj2";
            this.btnAgregarEj2.Size = new System.Drawing.Size(103, 39);
            this.btnAgregarEj2.TabIndex = 4;
            this.btnAgregarEj2.Text = "Agregar";
            this.btnAgregarEj2.UseVisualStyleBackColor = true;
            this.btnAgregarEj2.Click += new System.EventHandler(this.btnAgregarEj2_Click);
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxIngresodeDatos);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre y Apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio2_FormClosed);
            this.gbxIngresodeDatos.ResumeLayout(false);
            this.gbxIngresodeDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIngresodeDatos;
        private System.Windows.Forms.TextBox tbxApellidoEj2;
        private System.Windows.Forms.TextBox tbxNombreEj2;
        private System.Windows.Forms.Label lblApellidoEj2;
        private System.Windows.Forms.Label lblNombreEj2;
        private System.Windows.Forms.Button btnAgregarEj2;
    }
}