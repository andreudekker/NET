namespace WInformsRecuperaRegistro
{
    partial class FrmLeerValoresRecWin
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRegistroWindows = new System.Windows.Forms.Button();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 105);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(363, 20);
            this.txtValor.TabIndex = 0;
            // 
            // btnRegistroWindows
            // 
            this.btnRegistroWindows.Location = new System.Drawing.Point(42, 60);
            this.btnRegistroWindows.Name = "btnRegistroWindows";
            this.btnRegistroWindows.Size = new System.Drawing.Size(264, 23);
            this.btnRegistroWindows.TabIndex = 1;
            this.btnRegistroWindows.Text = "Obtener valor del registro de windows";
            this.btnRegistroWindows.UseVisualStyleBackColor = true;
            this.btnRegistroWindows.Click += new System.EventHandler(this.btnRegistroWindows_Click);
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Location = new System.Drawing.Point(42, 151);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(264, 23);
            this.btnGuardarRegistro.TabIndex = 1;
            this.btnGuardarRegistro.Text = "Guardar Registro Windows";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnRegistroWindows_Click);
            // 
            // FrmLeerValoresRecWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.btnRegistroWindows);
            this.Controls.Add(this.txtValor);
            this.Name = "FrmLeerValoresRecWin";
            this.Text = "leery guardar valores al registro de windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRegistroWindows;
        private System.Windows.Forms.Button btnGuardarRegistro;
    }
}