namespace FreddansBokhandel
{
    partial class FormAddNewOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.comboBoxStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPostalAdress = new System.Windows.Forms.TextBox();
            this.textBoxPostalNumber = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSeller = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelAmount);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxBooks);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxStores);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(822, 443);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(69, 415);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(13, 15);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lagerstatus: 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 404);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lägg till i korgen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 15;
            this.listBoxBooks.Location = new System.Drawing.Point(3, 46);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(393, 349);
            this.listBoxBooks.TabIndex = 0;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // comboBoxStores
            // 
            this.comboBoxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStores.FormattingEnabled = true;
            this.comboBoxStores.Location = new System.Drawing.Point(46, 6);
            this.comboBoxStores.Name = "comboBoxStores";
            this.comboBoxStores.Size = new System.Drawing.Size(204, 23);
            this.comboBoxStores.Sorted = true;
            this.comboBoxStores.TabIndex = 0;
            this.comboBoxStores.SelectedIndexChanged += new System.EventHandler(this.comboBoxStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Butik:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxCountry);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxPostalAdress);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxPostalNumber);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxAdress);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxLastName);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxSurName);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxOrderID);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxSeller);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxCart);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Size = new System.Drawing.Size(419, 443);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Enabled = false;
            this.textBoxCountry.Location = new System.Drawing.Point(76, 189);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(127, 23);
            this.textBoxCountry.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Land:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Postort:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Postnr:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adress:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Efternamn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Förnamn:";
            // 
            // textBoxPostalAdress
            // 
            this.textBoxPostalAdress.Enabled = false;
            this.textBoxPostalAdress.Location = new System.Drawing.Point(248, 160);
            this.textBoxPostalAdress.Name = "textBoxPostalAdress";
            this.textBoxPostalAdress.Size = new System.Drawing.Size(168, 23);
            this.textBoxPostalAdress.TabIndex = 9;
            // 
            // textBoxPostalNumber
            // 
            this.textBoxPostalNumber.Enabled = false;
            this.textBoxPostalNumber.Location = new System.Drawing.Point(76, 160);
            this.textBoxPostalNumber.Name = "textBoxPostalNumber";
            this.textBoxPostalNumber.Size = new System.Drawing.Size(81, 23);
            this.textBoxPostalNumber.TabIndex = 8;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Enabled = false;
            this.textBoxAdress.Location = new System.Drawing.Point(76, 131);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(340, 23);
            this.textBoxAdress.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(289, 102);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(127, 23);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Enabled = false;
            this.textBoxSurName.Location = new System.Drawing.Point(76, 102);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(127, 23);
            this.textBoxSurName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mottagare:";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(57, 6);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.ReadOnly = true;
            this.textBoxOrderID.Size = new System.Drawing.Size(109, 23);
            this.textBoxOrderID.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 26, 0, 0, 0, 0);
            // 
            // comboBoxSeller
            // 
            this.comboBoxSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeller.FormattingEnabled = true;
            this.comboBoxSeller.Location = new System.Drawing.Point(234, 6);
            this.comboBoxSeller.Name = "comboBoxSeller";
            this.comboBoxSeller.Size = new System.Drawing.Size(176, 23);
            this.comboBoxSeller.Sorted = true;
            this.comboBoxSeller.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Säljare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order:";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(416, 139);
            this.label12.TabIndex = 0;
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 15;
            this.listBoxCart.Location = new System.Drawing.Point(3, 12);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(413, 154);
            this.listBoxCart.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Slutför order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Töm korgen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddNewOrder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxStores;
        private System.Windows.Forms.ComboBox comboBoxSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPostalAdress;
        private System.Windows.Forms.TextBox textBoxPostalNumber;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label13;
    }
}