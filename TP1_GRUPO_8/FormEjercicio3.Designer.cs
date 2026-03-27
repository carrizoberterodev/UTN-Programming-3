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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rBtnMasculino);
            this.gbSexo.Controls.Add(this.rBtnFemenino);
            this.gbSexo.Location = new System.Drawing.Point(71, 11);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(2);
            this.gbSexo.Size = new System.Drawing.Size(117, 72);
            this.gbSexo.TabIndex = 2;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rBtnMasculino
            // 
            this.rBtnMasculino.AutoSize = true;
            this.rBtnMasculino.Location = new System.Drawing.Point(14, 38);
            this.rBtnMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnMasculino.Name = "rBtnMasculino";
            this.rBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rBtnMasculino.TabIndex = 1;
            this.rBtnMasculino.Text = "Masculino";
            this.rBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rBtnFemenino
            // 
            this.rBtnFemenino.AutoSize = true;
            this.rBtnFemenino.Checked = true;
            this.rBtnFemenino.Location = new System.Drawing.Point(14, 17);
            this.rBtnFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnFemenino.Name = "rBtnFemenino";
            this.rBtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rBtnFemenino.TabIndex = 0;
            this.rBtnFemenino.TabStop = true;
            this.rBtnFemenino.Text = "Femenino";
            this.rBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // clbOficio
            // 
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficio.Location = new System.Drawing.Point(187, 99);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(204, 79);
            this.clbOficio.TabIndex = 4;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rBtnSoltero);
            this.gbEstadoCivil.Controls.Add(this.rBtnCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(381, 11);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstadoCivil.Size = new System.Drawing.Size(121, 72);
            this.gbEstadoCivil.TabIndex = 2;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rBtnSoltero
            // 
            this.rBtnSoltero.AutoSize = true;
            this.rBtnSoltero.Location = new System.Drawing.Point(14, 38);
            this.rBtnSoltero.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnSoltero.Name = "rBtnSoltero";
            this.rBtnSoltero.Size = new System.Drawing.Size(58, 17);
            this.rBtnSoltero.TabIndex = 1;
            this.rBtnSoltero.Text = "Soltero";
            this.rBtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rBtnCasado
            // 
            this.rBtnCasado.AutoSize = true;
            this.rBtnCasado.Checked = true;
            this.rBtnCasado.Location = new System.Drawing.Point(14, 17);
            this.rBtnCasado.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnCasado.Name = "rBtnCasado";
            this.rBtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rBtnCasado.TabIndex = 0;
            this.rBtnCasado.TabStop = true;
            this.rBtnCasado.Text = "Casado";
            this.rBtnCasado.UseMnemonic = false;
            this.rBtnCasado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar lo que se selecciono";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(264, 245);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 13);
            this.lblTexto.TabIndex = 6;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clbOficio);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rBtnMasculino;
        private System.Windows.Forms.RadioButton rBtnFemenino;
        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rBtnSoltero;
        private System.Windows.Forms.RadioButton rBtnCasado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTexto;
    }
}