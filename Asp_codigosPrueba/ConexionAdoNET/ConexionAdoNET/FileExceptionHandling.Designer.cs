﻿namespace ConexionAdoNET
{
    partial class FileExceptionHandling
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
            this.lblPathWrite = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblPathRead = new System.Windows.Forms.Label();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.txtFileWritePath = new System.Windows.Forms.TextBox();
            this.txtFileText = new System.Windows.Forms.TextBox();
            this.txtFileReadPath = new System.Windows.Forms.TextBox();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPathWrite
            // 
            this.lblPathWrite.AutoSize = true;
            this.lblPathWrite.Location = new System.Drawing.Point(16, 17);
            this.lblPathWrite.Name = "lblPathWrite";
            this.lblPathWrite.Size = new System.Drawing.Size(104, 13);
            this.lblPathWrite.TabIndex = 0;
            this.lblPathWrite.Text = "Enter File Write Path";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(16, 48);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(75, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Enter your text";
            // 
            // lblPathRead
            // 
            this.lblPathRead.AutoSize = true;
            this.lblPathRead.Location = new System.Drawing.Point(16, 141);
            this.lblPathRead.Name = "lblPathRead";
            this.lblPathRead.Size = new System.Drawing.Size(105, 13);
            this.lblPathRead.TabIndex = 2;
            this.lblPathRead.Text = "Enter File Read Path";
            // 
            // lblFileContent
            // 
            this.lblFileContent.AutoSize = true;
            this.lblFileContent.Location = new System.Drawing.Point(16, 191);
            this.lblFileContent.Name = "lblFileContent";
            this.lblFileContent.Size = new System.Drawing.Size(63, 13);
            this.lblFileContent.TabIndex = 3;
            this.lblFileContent.Text = "File Content";
            // 
            // txtFileWritePath
            // 
            this.txtFileWritePath.Location = new System.Drawing.Point(126, 17);
            this.txtFileWritePath.Name = "txtFileWritePath";
            this.txtFileWritePath.Size = new System.Drawing.Size(301, 20);
            this.txtFileWritePath.TabIndex = 4;
            // 
            // txtFileText
            // 
            this.txtFileText.Location = new System.Drawing.Point(126, 48);
            this.txtFileText.Multiline = true;
            this.txtFileText.Name = "txtFileText";
            this.txtFileText.Size = new System.Drawing.Size(301, 60);
            this.txtFileText.TabIndex = 5;
            // 
            // txtFileReadPath
            // 
            this.txtFileReadPath.Location = new System.Drawing.Point(126, 141);
            this.txtFileReadPath.Name = "txtFileReadPath";
            this.txtFileReadPath.Size = new System.Drawing.Size(301, 20);
            this.txtFileReadPath.TabIndex = 6;
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(126, 188);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(301, 90);
            this.txtFileContent.TabIndex = 7;
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(464, 15);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteToFile.TabIndex = 8;
            this.btnWriteToFile.Text = "Write To File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(464, 141);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 9;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // FileExceptionHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 316);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.txtFileReadPath);
            this.Controls.Add(this.txtFileText);
            this.Controls.Add(this.txtFileWritePath);
            this.Controls.Add(this.lblFileContent);
            this.Controls.Add(this.lblPathRead);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblPathWrite);
            this.Name = "FileExceptionHandling";
            this.Text = "File-Read/Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathWrite;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblPathRead;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.TextBox txtFileWritePath;
        private System.Windows.Forms.TextBox txtFileText;
        private System.Windows.Forms.TextBox txtFileReadPath;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Button btnReadFile;
    }
}

