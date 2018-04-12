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
            this.get = new System.Windows.Forms.Button();
            this.wybor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baza = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(600, 167);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(217, 65);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "usuń";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(600, 95);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(217, 66);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // sortButton1
            // 
            this.sortButton1.Location = new System.Drawing.Point(600, 238);
            this.sortButton1.Name = "sortButton1";
            this.sortButton1.Size = new System.Drawing.Size(217, 63);
            this.sortButton1.TabIndex = 4;
            this.sortButton1.Text = "sortuj";
            this.sortButton1.UseVisualStyleBackColor = true;
            this.sortButton1.Click += new System.EventHandler(this.sortButton1_Click);
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(600, 307);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(217, 61);
            this.get.TabIndex = 11;
            this.get.Text = "połącz z bazą";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // wybor
            // 
            this.wybor.FormattingEnabled = true;
            this.wybor.Location = new System.Drawing.Point(600, 61);
            this.wybor.Name = "wybor";
            this.wybor.Size = new System.Drawing.Size(217, 28);
            this.wybor.TabIndex = 15;
            this.wybor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "tabele do wyboru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 17;
            // 
            // baza
            // 
            this.baza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.baza.FullRowSelect = true;
            this.baza.Location = new System.Drawing.Point(50, 28);
            this.baza.MultiSelect = false;
            this.baza.Name = "baza";
            this.baza.Size = new System.Drawing.Size(505, 437);
            this.baza.TabIndex = 0;
            this.baza.UseCompatibleStateImageBehavior = false;
            this.baza.View = System.Windows.Forms.View.Details;
            this.baza.VirtualListSize = 1;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAME";
            this.columnHeader2.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 477);
            this.Controls.Add(this.baza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wybor);
            this.Controls.Add(this.get);
            this.Controls.Add(this.sortButton1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button sortButton1;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.ComboBox wybor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView baza;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

