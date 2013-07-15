namespace WinformsRegistroSQl
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtUnidadDeMedida = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPreciodeVenta = new System.Windows.Forms.TextBox();
            this.CboDescripcion = new System.Windows.Forms.ComboBox();
            this.btnRegistrarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unidad de medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio de venta";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(159, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtUnidadDeMedida
            // 
            this.txtUnidadDeMedida.Location = new System.Drawing.Point(159, 90);
            this.txtUnidadDeMedida.Name = "txtUnidadDeMedida";
            this.txtUnidadDeMedida.Size = new System.Drawing.Size(220, 20);
            this.txtUnidadDeMedida.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(159, 127);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(220, 20);
            this.txtCosto.TabIndex = 1;
            // 
            // txtPreciodeVenta
            // 
            this.txtPreciodeVenta.Location = new System.Drawing.Point(159, 153);
            this.txtPreciodeVenta.Name = "txtPreciodeVenta";
            this.txtPreciodeVenta.Size = new System.Drawing.Size(220, 20);
            this.txtPreciodeVenta.TabIndex = 1;
            // 
            // CboDescripcion
            // 
            this.CboDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDescripcion.FormattingEnabled = true;
            this.CboDescripcion.Location = new System.Drawing.Point(159, 57);
            this.CboDescripcion.Name = "CboDescripcion";
            this.CboDescripcion.Size = new System.Drawing.Size(121, 21);
            this.CboDescripcion.TabIndex = 2;
            // 
            // btnRegistrarDatos
            // 
            this.btnRegistrarDatos.Location = new System.Drawing.Point(159, 192);
            this.btnRegistrarDatos.Name = "btnRegistrarDatos";
            this.btnRegistrarDatos.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrarDatos.TabIndex = 3;
            this.btnRegistrarDatos.Text = "Registrar Datos";
            this.btnRegistrarDatos.UseVisualStyleBackColor = true;
            this.btnRegistrarDatos.Click += new System.EventHandler(this.btnRegistrarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 262);
            this.Controls.Add(this.btnRegistrarDatos);
            this.Controls.Add(this.CboDescripcion);
            this.Controls.Add(this.txtPreciodeVenta);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtUnidadDeMedida);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtUnidadDeMedida;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPreciodeVenta;
        private System.Windows.Forms.ComboBox CboDescripcion;
        private System.Windows.Forms.Button btnRegistrarDatos;
    }
}

