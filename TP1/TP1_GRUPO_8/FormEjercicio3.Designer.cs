namespace TP1_GRUPO_8
{
    partial class FormEjercicio3
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
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rBtnMasculino = new System.Windows.Forms.RadioButton();
            this.rBtnFemenino = new System.Windows.Forms.RadioButton();
            this.clbOficio = new System.Windows.Forms.CheckedListBox();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rBtnSoltero = new System.Windows.Forms.RadioButton();
            this.rBtnCasado = new System.Windows.Forms.RadioButton();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rBtnMasculino);
            this.gbSexo.Controls.Add(this.rBtnFemenino);
            this.gbSexo.Location = new System.Drawing.Point(138, 75);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSexo.Size = new System.Drawing.Size(156, 89);
            this.gbSexo.TabIndex = 2;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rBtnMasculino
            // 
            this.rBtnMasculino.AutoSize = true;
            this.rBtnMasculino.Location = new System.Drawing.Point(19, 47);
            this.rBtnMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnMasculino.Name = "rBtnMasculino";
            this.rBtnMasculino.Size = new System.Drawing.Size(89, 20);
            this.rBtnMasculino.TabIndex = 1;
            this.rBtnMasculino.Text = "Masculino";
            this.rBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rBtnFemenino
            // 
            this.rBtnFemenino.AutoSize = true;
            this.rBtnFemenino.Checked = true;
            this.rBtnFemenino.Location = new System.Drawing.Point(19, 21);
            this.rBtnFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnFemenino.Name = "rBtnFemenino";
            this.rBtnFemenino.Size = new System.Drawing.Size(88, 20);
            this.rBtnFemenino.TabIndex = 0;
            this.rBtnFemenino.TabStop = true;
            this.rBtnFemenino.Text = "Femenino";
            this.rBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // clbOficio
            // 
            this.clbOficio.CheckOnClick = true;
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Location = new System.Drawing.Point(253, 215);
            this.clbOficio.Margin = new System.Windows.Forms.Padding(4);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(271, 106);
            this.clbOficio.TabIndex = 4;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rBtnSoltero);
            this.gbEstadoCivil.Controls.Add(this.rBtnCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(488, 75);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstadoCivil.Size = new System.Drawing.Size(161, 89);
            this.gbEstadoCivil.TabIndex = 2;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rBtnSoltero
            // 
            this.rBtnSoltero.AutoSize = true;
            this.rBtnSoltero.Location = new System.Drawing.Point(19, 47);
            this.rBtnSoltero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnSoltero.Name = "rBtnSoltero";
            this.rBtnSoltero.Size = new System.Drawing.Size(71, 20);
            this.rBtnSoltero.TabIndex = 1;
            this.rBtnSoltero.Text = "Soltero";
            this.rBtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rBtnCasado
            // 
            this.rBtnCasado.AutoSize = true;
            this.rBtnCasado.Checked = true;
            this.rBtnCasado.Location = new System.Drawing.Point(19, 21);
            this.rBtnCasado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnCasado.Name = "rBtnCasado";
            this.rBtnCasado.Size = new System.Drawing.Size(76, 20);
            this.rBtnCasado.TabIndex = 0;
            this.rBtnCasado.TabStop = true;
            this.rBtnCasado.Text = "Casado";
            this.rBtnCasado.UseMnemonic = false;
            this.rBtnCasado.UseVisualStyleBackColor = true;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbOficio);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio3_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rBtnMasculino;
        private System.Windows.Forms.RadioButton rBtnFemenino;
        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rBtnSoltero;
        private System.Windows.Forms.RadioButton rBtnCasado;
    }
}