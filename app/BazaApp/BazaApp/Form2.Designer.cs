﻿namespace BazaApp
{
    partial class Form2
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
            this.title = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.addButon = new System.Windows.Forms.Button();
            this.cancelButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(37, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(249, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Podaj nazwę nowego użytkownika";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(41, 74);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(363, 26);
            this.textBoxNewName.TabIndex = 1;
            this.textBoxNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNewName.TextChanged += new System.EventHandler(this.textBoxNewName_TextChanged);
            // 
            // addButon
            // 
            this.addButon.Location = new System.Drawing.Point(41, 124);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(152, 62);
            this.addButon.TabIndex = 2;
            this.addButon.Text = "dodaj";
            this.addButon.UseVisualStyleBackColor = true;
            this.addButon.Click += new System.EventHandler(this.addButon_Click);
            // 
            // cancelButon
            // 
            this.cancelButon.Location = new System.Drawing.Point(252, 124);
            this.cancelButon.Name = "cancelButon";
            this.cancelButon.Size = new System.Drawing.Size(152, 62);
            this.cancelButon.TabIndex = 3;
            this.cancelButon.Text = "zamknij okno";
            this.cancelButon.UseVisualStyleBackColor = true;
            this.cancelButon.Click += new System.EventHandler(this.cancelButon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 222);
            this.Controls.Add(this.cancelButon);
            this.Controls.Add(this.addButon);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.Button cancelButon;
    }
}