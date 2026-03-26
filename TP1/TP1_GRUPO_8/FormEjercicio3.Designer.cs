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
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rBtnMasculino);
            this.gbSexo.Controls.Add(this.rBtnFemenino);
            this.gbSexo.Location = new System.Drawing.Point(60, 61);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSexo.Size = new System.Drawing.Size(121, 72);
            this.gbSexo.TabIndex = 2;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rBtnMasculino
            // 
            this.rBtnMasculino.AutoSize = true;
            this.rBtnMasculino.Location = new System.Drawing.Point(14, 38);
            this.rBtnMasculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rBtnFemenino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnFemenino.Name = "rBtnFemenino";
            this.rBtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rBtnFemenino.TabIndex = 0;
            this.rBtnFemenino.TabStop = true;
            this.rBtnFemenino.Text = "Femenino";
            this.rBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // clbOficio
            // 
            this.clbOficio.CheckOnClick = true;
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Location = new System.Drawing.Point(248, 144);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(120, 94);
            this.clbOficio.TabIndex = 4;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.clbOficio);
            this.Controls.Add(this.gbSexo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio3_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rBtnMasculino;
        private System.Windows.Forms.RadioButton rBtnFemenino;
        private System.Windows.Forms.CheckedListBox clbOficio;
    }
}