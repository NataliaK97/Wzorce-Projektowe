namespace BazaApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.sortButton1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton2 = new System.Windows.Forms.Button();
            this.delButton2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(631, 101);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(114, 65);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "usuń";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(631, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 66);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // sortButton1
            // 
            this.sortButton1.Location = new System.Drawing.Point(631, 172);
            this.sortButton1.Name = "sortButton1";
            this.sortButton1.Size = new System.Drawing.Size(114, 63);
            this.sortButton1.TabIndex = 4;
            this.sortButton1.Text = "sortuj";
            this.sortButton1.UseVisualStyleBackColor = true;
            this.sortButton1.Click += new System.EventHandler(this.sortButton1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(362, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(184, 354);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.VirtualListSize = 1;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "podaj nazwę nowego użytkownika ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(12, 93);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(175, 34);
            this.addButton2.TabIndex = 6;
            this.addButton2.Text = "potwierdź dodanie";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // delButton2
            // 
            this.delButton2.Location = new System.Drawing.Point(12, 201);
            this.delButton2.Name = "delButton2";
            this.delButton2.Size = new System.Drawing.Size(175, 34);
            this.delButton2.TabIndex = 7;
            this.delButton2.Text = "potwierdż usunięcie";
            this.delButton2.UseVisualStyleBackColor = true;
            this.delButton2.Click += new System.EventHandler(this.delButton2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 172);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "lista użytkowników";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.delButton2);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sortButton1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button sortButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Button delButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

