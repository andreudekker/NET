namespace ProyectoBD
{
    partial class userInfo
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.CboState = new System.Windows.Forms.ComboBox();
            this.chkPostaMail = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveCountry = new System.Windows.Forms.Button();
            this.btnRemoveState = new System.Windows.Forms.Button();
            this.btnShowdetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(12, 26);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(71, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Enter Country";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(97, 19);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(129, 20);
            this.TxtCountry.TabIndex = 1;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(12, 65);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Enter State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(97, 58);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(129, 20);
            this.txtState.TabIndex = 3;
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.Location = new System.Drawing.Point(280, 12);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(129, 82);
            this.lstCountry.TabIndex = 4;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // CboState
            // 
            this.CboState.FormattingEnabled = true;
            this.CboState.Location = new System.Drawing.Point(280, 117);
            this.CboState.Name = "CboState";
            this.CboState.Size = new System.Drawing.Size(129, 21);
            this.CboState.TabIndex = 5;
            // 
            // chkPostaMail
            // 
            this.chkPostaMail.AutoSize = true;
            this.chkPostaMail.Location = new System.Drawing.Point(15, 106);
            this.chkPostaMail.Name = "chkPostaMail";
            this.chkPostaMail.Size = new System.Drawing.Size(72, 17);
            this.chkPostaMail.TabIndex = 6;
            this.chkPostaMail.Text = "PostaMail";
            this.chkPostaMail.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(14, 130);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 7;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(107, 105);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 8;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(107, 130);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 9;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveCountry
            // 
            this.btnRemoveCountry.Location = new System.Drawing.Point(105, 165);
            this.btnRemoveCountry.Name = "btnRemoveCountry";
            this.btnRemoveCountry.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveCountry.TabIndex = 11;
            this.btnRemoveCountry.Text = "RemoveCountry";
            this.btnRemoveCountry.UseVisualStyleBackColor = true;
            this.btnRemoveCountry.Click += new System.EventHandler(this.btnRemoveCountry_Click);
            // 
            // btnRemoveState
            // 
            this.btnRemoveState.Location = new System.Drawing.Point(220, 165);
            this.btnRemoveState.Name = "btnRemoveState";
            this.btnRemoveState.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveState.TabIndex = 12;
            this.btnRemoveState.Text = "RemoveState";
            this.btnRemoveState.UseVisualStyleBackColor = true;
            this.btnRemoveState.Click += new System.EventHandler(this.btnRemoveState_Click);
            // 
            // btnShowdetails
            // 
            this.btnShowdetails.Location = new System.Drawing.Point(327, 165);
            this.btnShowdetails.Name = "btnShowdetails";
            this.btnShowdetails.Size = new System.Drawing.Size(100, 23);
            this.btnShowdetails.TabIndex = 13;
            this.btnShowdetails.Text = "ShowDetails";
            this.btnShowdetails.UseVisualStyleBackColor = true;
            this.btnShowdetails.Click += new System.EventHandler(this.btnShowdetails_Click);
            // 
            // userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.Controls.Add(this.btnShowdetails);
            this.Controls.Add(this.btnRemoveState);
            this.Controls.Add(this.btnRemoveCountry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkPostaMail);
            this.Controls.Add(this.CboState);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.lblCountry);
            this.MaximumSize = new System.Drawing.Size(455, 251);
            this.Name = "userInfo";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lstCountry_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.ListBox lstCountry;
        private System.Windows.Forms.ComboBox CboState;
        private System.Windows.Forms.CheckBox chkPostaMail;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveCountry;
        private System.Windows.Forms.Button btnRemoveState;
        private System.Windows.Forms.Button btnShowdetails;
    }
}