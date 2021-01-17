namespace FreddansBokhandel
{
    partial class FormMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.tabPagePublishers = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageOrders);
            this.tabControl.Controls.Add(this.tabPageBooks);
            this.tabControl.Controls.Add(this.tabPageEmployees);
            this.tabControl.Controls.Add(this.tabPageAuthors);
            this.tabControl.Controls.Add(this.tabPagePublishers);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 5;
            this.tabControl.Size = new System.Drawing.Size(984, 513);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 24);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(976, 485);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Ordrar";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            this.tabPageOrders.Enter += new System.EventHandler(this.tabPageOrders_Enter);
            this.tabPageOrders.Leave += new System.EventHandler(this.tabPageOrders_Leave);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(976, 485);
            this.tabPageBooks.TabIndex = 1;
            this.tabPageBooks.Text = "Böcker";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            this.tabPageBooks.Enter += new System.EventHandler(this.tabPageBooks_Enter);
            this.tabPageBooks.Leave += new System.EventHandler(this.tabPageBooks_Leave);
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(976, 485);
            this.tabPageEmployees.TabIndex = 2;
            this.tabPageEmployees.Text = "Anställda";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            this.tabPageEmployees.Enter += new System.EventHandler(this.tabPageEmployees_Enter);
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(976, 485);
            this.tabPageAuthors.TabIndex = 4;
            this.tabPageAuthors.Text = "Författare";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            this.tabPageAuthors.Enter += new System.EventHandler(this.tabPageAuthors_Enter);
            // 
            // tabPagePublishers
            // 
            this.tabPagePublishers.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishers.Name = "tabPagePublishers";
            this.tabPagePublishers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishers.Size = new System.Drawing.Size(976, 485);
            this.tabPagePublishers.TabIndex = 5;
            this.tabPagePublishers.Text = "Förlag";
            this.tabPagePublishers.UseVisualStyleBackColor = true;
            this.tabPagePublishers.Enter += new System.EventHandler(this.tabPagePublishers_Enter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Freddans Bokhandel";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageAuthors;
        private System.Windows.Forms.TabPage tabPagePublishers;
    }
}