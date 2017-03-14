namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BooksListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescribeUser = new System.Windows.Forms.Button();
            this.DescribeBook = new System.Windows.Forms.Button();
            this.Lend = new System.Windows.Forms.Button();
            this.Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsersListbox
            // 
            this.UsersListbox.FormattingEnabled = true;
            this.UsersListbox.Items.AddRange(new object[] {
            "i nomi",
            "e i cognomi",
            "degli utenti",
            "del seeder"});
            this.UsersListbox.Location = new System.Drawing.Point(42, 40);
            this.UsersListbox.Name = "UsersListbox";
            this.UsersListbox.Size = new System.Drawing.Size(185, 290);
            this.UsersListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utenti:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BooksListbox
            // 
            this.BooksListbox.FormattingEnabled = true;
            this.BooksListbox.Items.AddRange(new object[] {
            "i titoli",
            "e i codici",
            "dei libri",
            "del seeder"});
            this.BooksListbox.Location = new System.Drawing.Point(480, 40);
            this.BooksListbox.Name = "BooksListbox";
            this.BooksListbox.Size = new System.Drawing.Size(185, 290);
            this.BooksListbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(617, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libri:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DescribeUser
            // 
            this.DescribeUser.BackColor = System.Drawing.SystemColors.Control;
            this.DescribeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescribeUser.Location = new System.Drawing.Point(65, 336);
            this.DescribeUser.Name = "DescribeUser";
            this.DescribeUser.Size = new System.Drawing.Size(115, 43);
            this.DescribeUser.TabIndex = 4;
            this.DescribeUser.Text = "Informazioni";
            this.DescribeUser.UseVisualStyleBackColor = false;
            this.DescribeUser.Click += new System.EventHandler(this.DescribeUser_Click);
            // 
            // DescribeBook
            // 
            this.DescribeBook.BackColor = System.Drawing.SystemColors.Control;
            this.DescribeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescribeBook.Location = new System.Drawing.Point(519, 336);
            this.DescribeBook.Name = "DescribeBook";
            this.DescribeBook.Size = new System.Drawing.Size(115, 43);
            this.DescribeBook.TabIndex = 5;
            this.DescribeBook.Text = "Informazioni";
            this.DescribeBook.UseVisualStyleBackColor = false;
            this.DescribeBook.Click += new System.EventHandler(this.DescribeBook_Click);
            // 
            // Lend
            // 
            this.Lend.BackColor = System.Drawing.SystemColors.Control;
            this.Lend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lend.Location = new System.Drawing.Point(306, 384);
            this.Lend.Name = "Lend";
            this.Lend.Size = new System.Drawing.Size(115, 43);
            this.Lend.TabIndex = 6;
            this.Lend.Text = "Presta";
            this.Lend.UseVisualStyleBackColor = false;
            // 
            // Txt
            // 
            this.Txt.Enabled = false;
            this.Txt.Location = new System.Drawing.Point(277, 40);
            this.Txt.Multiline = true;
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(157, 211);
            this.Txt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(719, 452);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.Lend);
            this.Controls.Add(this.DescribeBook);
            this.Controls.Add(this.DescribeUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BooksListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersListbox);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooksListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox UsersListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DescribeUser;
        private System.Windows.Forms.Button DescribeBook;
        private System.Windows.Forms.Button Lend;
        private System.Windows.Forms.TextBox Txt;
    }
}

