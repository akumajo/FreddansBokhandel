namespace FreddansBokhandel
{
    partial class UserControlAuthors
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
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Födelsedatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewAuthors);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddAuthor);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 585);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // dataGridView1
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Födelsedatum,
            this.Land});
            this.dataGridViewAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAuthors.Name = "dataGridView1";
            this.dataGridViewAuthors.ReadOnly = true;
            this.dataGridViewAuthors.RowHeadersVisible = false;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(1076, 540);
            this.dataGridViewAuthors.TabIndex = 0;
            this.dataGridViewAuthors.Text = "dataGridView1";
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
            // Födelsedatum
            // 
            this.Födelsedatum.HeaderText = "Födelsedatum";
            this.Födelsedatum.Name = "Födelsedatum";
            this.Födelsedatum.ReadOnly = true;
            // 
            // Land
            // 
            this.Land.HeaderText = "Land";
            this.Land.Name = "Land";
            this.Land.ReadOnly = true;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(0, 4);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(100, 34);
            this.buttonAddAuthor.TabIndex = 0;
            this.buttonAddAuthor.Text = "Lägg till";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlAuthors";
            this.Size = new System.Drawing.Size(1076, 585);
            this.Load += new System.EventHandler(this.UserControlAuthors_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Födelsedatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Land;
        private System.Windows.Forms.Button buttonAddAuthor;
    }
}
