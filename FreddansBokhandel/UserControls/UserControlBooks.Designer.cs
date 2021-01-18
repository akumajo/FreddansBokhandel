namespace FreddansBokhandel
{
    partial class UserControlBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonFilterBooks = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBookToStock = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOverview = new System.Windows.Forms.DataGridView();
            this.Butik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagervärde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(976, 485);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonFilterBooks);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFilter);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(400, 485);
            this.splitContainer2.SplitterDistance = 34;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // buttonFilterBooks
            // 
            this.buttonFilterBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilterBooks.Location = new System.Drawing.Point(317, 5);
            this.buttonFilterBooks.Name = "buttonFilterBooks";
            this.buttonFilterBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterBooks.TabIndex = 1;
            this.buttonFilterBooks.Text = "Filtrera";
            this.buttonFilterBooks.UseVisualStyleBackColor = true;
            this.buttonFilterBooks.Click += new System.EventHandler(this.buttonFilterBooks_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(1, 5);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(312, 23);
            this.textBoxFilter.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.buttonDeleteBook);
            this.splitContainer4.Panel2.Controls.Add(this.buttonAddBook);
            this.splitContainer4.Size = new System.Drawing.Size(400, 447);
            this.splitContainer4.SplitterDistance = 400;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.Text = "splitContainer4";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(1, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(391, 379);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteBook.Enabled = false;
            this.buttonDeleteBook.Location = new System.Drawing.Point(129, 6);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(119, 34);
            this.buttonDeleteBook.TabIndex = 3;
            this.buttonDeleteBook.Text = "Ta bort bok";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddBook.Location = new System.Drawing.Point(4, 6);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(119, 34);
            this.buttonAddBook.TabIndex = 3;
            this.buttonAddBook.Text = "Lägg till bok";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.buttonLoadImage);
            this.splitContainer3.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxAuthor);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxTitle);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxPublisher);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.buttonAddBookToStock);
            this.splitContainer3.Panel1.Controls.Add(this.buttonUpdateBook);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxReleaseDate);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxISBN);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxPages);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxLanguage);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxFormat);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxPrice);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewOverview);
            this.splitContainer3.Size = new System.Drawing.Size(572, 485);
            this.splitContainer3.SplitterDistance = 370;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.Text = "splitContainer3";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Enabled = false;
            this.buttonLoadImage.Location = new System.Drawing.Point(4, 48);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(236, 318);
            this.buttonLoadImage.TabIndex = 9;
            this.buttonLoadImage.Text = "Hämta bild";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 319);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthor.Location = new System.Drawing.Point(4, 30);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(477, 16);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(4, 5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(477, 22);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisher.Location = new System.Drawing.Point(287, 225);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(180, 16);
            this.textBoxPublisher.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Förlag: Test";
            // 
            // buttonAddBookToStock
            // 
            this.buttonAddBookToStock.Enabled = false;
            this.buttonAddBookToStock.Location = new System.Drawing.Point(318, 323);
            this.buttonAddBookToStock.Name = "buttonAddBookToStock";
            this.buttonAddBookToStock.Size = new System.Drawing.Size(119, 34);
            this.buttonAddBookToStock.TabIndex = 3;
            this.buttonAddBookToStock.Text = "Köp in bok";
            this.buttonAddBookToStock.UseVisualStyleBackColor = true;
            this.buttonAddBookToStock.Click += new System.EventHandler(this.buttonAddBookToStock_Click);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Enabled = false;
            this.buttonUpdateBook.Location = new System.Drawing.Point(443, 323);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(119, 34);
            this.buttonUpdateBook.TabIndex = 3;
            this.buttonUpdateBook.Text = "Ändra bok";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReleaseDate.Location = new System.Drawing.Point(290, 108);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(147, 16);
            this.textBoxReleaseDate.TabIndex = 8;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxISBN.Location = new System.Drawing.Point(279, 79);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(147, 16);
            this.textBoxISBN.TabIndex = 8;
            // 
            // textBoxPages
            // 
            this.textBoxPages.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPages.Location = new System.Drawing.Point(281, 50);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(147, 16);
            this.textBoxPages.TabIndex = 8;
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLanguage.Location = new System.Drawing.Point(283, 196);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(147, 16);
            this.textBoxLanguage.TabIndex = 8;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFormat.Location = new System.Drawing.Point(292, 167);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(147, 16);
            this.textBoxFormat.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Location = new System.Drawing.Point(273, 137);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 16);
            this.textBoxPrice.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "ISBN: 0000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Format: Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sidor: 000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum: 0000-00-00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pris: 000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Språk: Test";
            // 
            // dataGridViewOverview
            // 
            this.dataGridViewOverview.AllowUserToAddRows = false;
            this.dataGridViewOverview.AllowUserToDeleteRows = false;
            this.dataGridViewOverview.AllowUserToResizeColumns = false;
            this.dataGridViewOverview.AllowUserToResizeRows = false;
            this.dataGridViewOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOverview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Butik,
            this.Antal,
            this.Lagervärde});
            this.dataGridViewOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOverview.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOverview.MultiSelect = false;
            this.dataGridViewOverview.Name = "dataGridViewOverview";
            this.dataGridViewOverview.ReadOnly = true;
            this.dataGridViewOverview.RowHeadersVisible = false;
            this.dataGridViewOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOverview.Size = new System.Drawing.Size(572, 111);
            this.dataGridViewOverview.TabIndex = 0;
            this.dataGridViewOverview.Text = "dataGridView1";
            // 
            // Butik
            // 
            this.Butik.HeaderText = "Butik";
            this.Butik.Name = "Butik";
            this.Butik.ReadOnly = true;
            // 
            // Antal
            // 
            this.Antal.HeaderText = "Antal";
            this.Antal.Name = "Antal";
            this.Antal.ReadOnly = true;
            // 
            // Lagervärde
            // 
            this.Lagervärde.HeaderText = "Lagervärde";
            this.Lagervärde.Name = "Lagervärde";
            this.Lagervärde.ReadOnly = true;
            // 
            // UserControlBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlBooks";
            this.Size = new System.Drawing.Size(976, 485);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonFilterBooks;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Butik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagervärde;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddBookToStock;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoadImage;
    }
}
