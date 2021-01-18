namespace FreddansBokhandel
{
    partial class UserControlPublishers
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
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.buttonEditPublisher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewPublishers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditPublisher);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddPublisher);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 585);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AllowUserToAddRows = false;
            this.dataGridViewPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Adress,
            this.Postnr,
            this.Postort,
            this.Land});
            this.dataGridViewPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPublishers.MultiSelect = false;
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.ReadOnly = true;
            this.dataGridViewPublishers.RowHeadersVisible = false;
            this.dataGridViewPublishers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(1076, 540);
            this.dataGridViewPublishers.TabIndex = 0;
            this.dataGridViewPublishers.Text = "dataGridView1";
            this.dataGridViewPublishers.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewPublishers_RowStateChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Namn
            // 
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Postnr
            // 
            this.Postnr.HeaderText = "Postnr";
            this.Postnr.Name = "Postnr";
            this.Postnr.ReadOnly = true;
            // 
            // Postort
            // 
            this.Postort.HeaderText = "Postort";
            this.Postort.Name = "Postort";
            this.Postort.ReadOnly = true;
            // 
            // Land
            // 
            this.Land.HeaderText = "Land";
            this.Land.Name = "Land";
            this.Land.ReadOnly = true;
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Location = new System.Drawing.Point(0, 4);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(100, 34);
            this.buttonAddPublisher.TabIndex = 0;
            this.buttonAddPublisher.Text = "Lägg till";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonEditPublisher
            // 
            this.buttonEditPublisher.Location = new System.Drawing.Point(107, 4);
            this.buttonEditPublisher.Name = "buttonEditPublisher";
            this.buttonEditPublisher.Size = new System.Drawing.Size(100, 34);
            this.buttonEditPublisher.TabIndex = 1;
            this.buttonEditPublisher.Text = "Ändra";
            this.buttonEditPublisher.UseVisualStyleBackColor = true;
            this.buttonEditPublisher.Click += new System.EventHandler(this.buttonEditPublisher_Click);
            // 
            // UserControlPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlPublishers";
            this.Size = new System.Drawing.Size(1076, 585);
            this.Load += new System.EventHandler(this.UserControlPublishers_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Land;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.Button buttonEditPublisher;
    }
}
