namespace FreddansBokhandel
{
    partial class FormAddOrEditBook
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonRemoveAuthor1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAuthor2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxAuthor3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonRemoveAuthor3 = new System.Windows.Forms.Button();
            this.buttonRemoveAuthor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(66, 12);
            this.textBoxTitle.MaxLength = 100;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(526, 23);
            this.textBoxTitle.TabIndex = 1;
            // 
            // buttonRemoveAuthor1
            // 
            this.buttonRemoveAuthor1.Location = new System.Drawing.Point(598, 41);
            this.buttonRemoveAuthor1.Name = "buttonRemoveAuthor1";
            this.buttonRemoveAuthor1.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAuthor1.TabIndex = 6;
            this.buttonRemoveAuthor1.Text = "Ta bort";
            this.buttonRemoveAuthor1.UseVisualStyleBackColor = true;
            this.buttonRemoveAuthor1.Click += new System.EventHandler(this.buttonRemoveAuthor1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Författare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Utgivningsdatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Antal sidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Språk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Format:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Förlag:";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(66, 99);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(204, 23);
            this.comboBoxPublisher.Sorted = true;
            this.comboBoxPublisher.TabIndex = 1;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(66, 41);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(203, 23);
            this.textBoxISBN.TabIndex = 2;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(66, 70);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(204, 23);
            this.comboBoxFormat.Sorted = true;
            this.comboBoxFormat.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 16, 0, 0, 0, 0);
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(388, 128);
            this.textBoxPages.MaxLength = 9;
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(80, 23);
            this.textBoxPages.TabIndex = 4;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(388, 41);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(204, 23);
            this.comboBoxAuthor.Sorted = true;
            this.comboBoxAuthor.TabIndex = 1;
            this.comboBoxAuthor.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthor_SelectedIndexChanged);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(66, 128);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(204, 23);
            this.comboBoxLanguage.Sorted = true;
            this.comboBoxLanguage.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Författare:";
            // 
            // comboBoxAuthor2
            // 
            this.comboBoxAuthor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor2.FormattingEnabled = true;
            this.comboBoxAuthor2.Location = new System.Drawing.Point(388, 70);
            this.comboBoxAuthor2.Name = "comboBoxAuthor2";
            this.comboBoxAuthor2.Size = new System.Drawing.Size(204, 23);
            this.comboBoxAuthor2.Sorted = true;
            this.comboBoxAuthor2.TabIndex = 1;
            this.comboBoxAuthor2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthor2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Författare:";
            // 
            // comboBoxAuthor3
            // 
            this.comboBoxAuthor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor3.FormattingEnabled = true;
            this.comboBoxAuthor3.Location = new System.Drawing.Point(388, 99);
            this.comboBoxAuthor3.Name = "comboBoxAuthor3";
            this.comboBoxAuthor3.Size = new System.Drawing.Size(204, 23);
            this.comboBoxAuthor3.Sorted = true;
            this.comboBoxAuthor3.TabIndex = 1;
            this.comboBoxAuthor3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthor3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pris:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(66, 157);
            this.textBoxPrice.MaxLength = 9;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(80, 23);
            this.textBoxPrice.TabIndex = 4;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(573, 186);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(100, 34);
            this.buttonAddBook.TabIndex = 5;
            this.buttonAddBook.Text = "Lägg till";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonRemoveAuthor3
            // 
            this.buttonRemoveAuthor3.Location = new System.Drawing.Point(598, 99);
            this.buttonRemoveAuthor3.Name = "buttonRemoveAuthor3";
            this.buttonRemoveAuthor3.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAuthor3.TabIndex = 6;
            this.buttonRemoveAuthor3.Text = "Ta bort";
            this.buttonRemoveAuthor3.UseVisualStyleBackColor = true;
            this.buttonRemoveAuthor3.Click += new System.EventHandler(this.buttonRemoveAuthor3_Click);
            // 
            // buttonRemoveAuthor2
            // 
            this.buttonRemoveAuthor2.Location = new System.Drawing.Point(598, 70);
            this.buttonRemoveAuthor2.Name = "buttonRemoveAuthor2";
            this.buttonRemoveAuthor2.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAuthor2.TabIndex = 6;
            this.buttonRemoveAuthor2.Text = "Ta bort";
            this.buttonRemoveAuthor2.UseVisualStyleBackColor = true;
            this.buttonRemoveAuthor2.Click += new System.EventHandler(this.buttonRemoveAuthor2_Click);
            // 
            // FormAddOrEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 227);
            this.Controls.Add(this.buttonRemoveAuthor2);
            this.Controls.Add(this.buttonRemoveAuthor1);
            this.Controls.Add(this.buttonRemoveAuthor3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.comboBoxAuthor3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxAuthor2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddOrEditBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lägg till ny bok";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonRemoveAuthor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAuthor2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxAuthor3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonRemoveAuthor3;
        private System.Windows.Forms.Button buttonRemoveAuthor2;
    }
}