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
            this.rBtnFemenino = new System.Windows.Forms.RadioButton();
            this.rBtnMasculino = new System.Windows.Forms.RadioButton();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rBtnMasculino);
            this.gbSexo.Controls.Add(this.rBtnFemenino);
            this.gbSexo.Location = new System.Drawing.Point(78, 75);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(161, 89);
            this.gbSexo.TabIndex = 2;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rBtnFemenino
            // 
            this.rBtnFemenino.AutoSize = true;
            this.rBtnFemenino.Checked = true;
            this.rBtnFemenino.Location = new System.Drawing.Point(19, 21);
            this.rBtnFemenino.Name = "rBtnFemenino";
            this.rBtnFemenino.Size = new System.Drawing.Size(88, 20);
            this.rBtnFemenino.TabIndex = 0;
            this.rBtnFemenino.TabStop = true;
            this.rBtnFemenino.Text = "Femenino";
            this.rBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rBtnMasculino
            // 
            this.rBtnMasculino.AutoSize = true;
            this.rBtnMasculino.Location = new System.Drawing.Point(19, 47);
            this.rBtnMasculino.Name = "rBtnMasculino";
            this.rBtnMasculino.Size = new System.Drawing.Size(89, 20);
            this.rBtnMasculino.TabIndex = 1;
            this.rBtnMasculino.Text = "Masculino";
            this.rBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSexo);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEjercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rBtnMasculino;
        private System.Windows.Forms.RadioButton rBtnFemenino;
    }
}