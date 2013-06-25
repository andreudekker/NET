namespace Directorio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactoIDLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultima_llamadaLabel;
            System.Windows.Forms.Label emailLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactoIDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.ultima_llamadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.genteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDBDataSet1 = new Directorio.ContactDBDataSet();
            this.contactDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genteTableAdapter = new Directorio.ContactDBDataSetTableAdapters.GenteTableAdapter();
            this.tableAdapterManager = new Directorio.ContactDBDataSetTableAdapters.TableAdapterManager();
            contactoIDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultima_llamadaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactoIDLabel
            // 
            contactoIDLabel.AutoSize = true;
            contactoIDLabel.Location = new System.Drawing.Point(34, 30);
            contactoIDLabel.Name = "contactoIDLabel";
            contactoIDLabel.Size = new System.Drawing.Size(67, 13);
            contactoIDLabel.TabIndex = 1;
            contactoIDLabel.Text = "Contacto ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(34, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(34, 111);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(51, 13);
            empresaLabel.TabIndex = 5;
            empresaLabel.Text = "Empresa:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(34, 150);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(34, 183);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 9;
            clienteLabel.Text = "Cliente:";
            // 
            // ultima_llamadaLabel
            // 
            ultima_llamadaLabel.AutoSize = true;
            ultima_llamadaLabel.Location = new System.Drawing.Point(34, 226);
            ultima_llamadaLabel.Name = "ultima_llamadaLabel";
            ultima_llamadaLabel.Size = new System.Drawing.Size(78, 13);
            ultima_llamadaLabel.TabIndex = 11;
            ultima_llamadaLabel.Text = "Ultima llamada:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(34, 267);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Directorio.Properties.Resources.Nelson;
            this.pictureBox1.Location = new System.Drawing.Point(255, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactoIDTextBox
            // 
            this.contactoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genteBindingSource, "ContactoID", true));
            this.contactoIDTextBox.Location = new System.Drawing.Point(124, 27);
            this.contactoIDTextBox.Name = "contactoIDTextBox";
            this.contactoIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoIDTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genteBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(124, 69);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genteBindingSource, "Empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(124, 108);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.empresaTextBox.TabIndex = 6;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genteBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(124, 147);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.genteBindingSource, "Cliente", true));
            this.clienteCheckBox.Location = new System.Drawing.Point(124, 178);
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.clienteCheckBox.TabIndex = 10;
            this.clienteCheckBox.Text = "checkBox1";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ultima_llamadaDateTimePicker
            // 
            this.ultima_llamadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.genteBindingSource, "Ultima llamada", true));
            this.ultima_llamadaDateTimePicker.Location = new System.Drawing.Point(124, 220);
            this.ultima_llamadaDateTimePicker.Name = "ultima_llamadaDateTimePicker";
            this.ultima_llamadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ultima_llamadaDateTimePicker.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(124, 264);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // genteBindingSource
            // 
            this.genteBindingSource.DataMember = "Gente";
            this.genteBindingSource.DataSource = this.contactDBDataSet1;
            this.genteBindingSource.CurrentChanged += new System.EventHandler(this.genteBindingSource_CurrentChanged);
            // 
            // contactDBDataSet1
            // 
            this.contactDBDataSet1.DataSetName = "ContactDBDataSet";
            this.contactDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactDBDataSet1BindingSource
            // 
            this.contactDBDataSet1BindingSource.DataSource = this.contactDBDataSet1;
            this.contactDBDataSet1BindingSource.Position = 0;
            this.contactDBDataSet1BindingSource.CurrentChanged += new System.EventHandler(this.contactDBDataSet1BindingSource_CurrentChanged);
            // 
            // genteTableAdapter
            // 
            this.genteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenteTableAdapter = this.genteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Directorio.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 369);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(ultima_llamadaLabel);
            this.Controls.Add(this.ultima_llamadaDateTimePicker);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(contactoIDLabel);
            this.Controls.Add(this.contactoIDTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactDBDataSet contactDBDataSet1;
        private System.Windows.Forms.BindingSource contactDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource genteBindingSource;
        private ContactDBDataSetTableAdapters.GenteTableAdapter genteTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox contactoIDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.DateTimePicker ultima_llamadaDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

