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
            this.Böcker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonRemoveAuthor = new System.Windows.Forms.Button();
            this.buttonEditAuthor = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemoveAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddAuthor);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 585);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Födelsedatum,
            this.Land,
            this.Böcker});
            this.dataGridViewAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAuthors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersVisible = false;
            this.dataGridViewAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(1076, 540);
            this.dataGridViewAuthors.TabIndex = 0;
            this.dataGridViewAuthors.Text = "dataGridView1";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Namn
            // 
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            this.Namn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Födelsedatum
            // 
            this.Födelsedatum.HeaderText = "Födelsedatum";
            this.Födelsedatum.Name = "Födelsedatum";
            this.Födelsedatum.ReadOnly = true;
            this.Födelsedatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Land
            // 
            this.Land.HeaderText = "Land";
            this.Land.Name = "Land";
            this.Land.ReadOnly = true;
            this.Land.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Böcker
            // 
            this.Böcker.HeaderText = "Böcker";
            this.Böcker.Name = "Böcker";
            this.Böcker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Böcker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonRemoveAuthor
            // 
            this.buttonRemoveAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveAuthor.Location = new System.Drawing.Point(973, 4);
            this.buttonRemoveAuthor.Name = "buttonRemoveAuthor";
            this.buttonRemoveAuthor.Size = new System.Drawing.Size(100, 34);
            this.buttonRemoveAuthor.TabIndex = 2;
            this.buttonRemoveAuthor.Text = "Ta bort";
            this.buttonRemoveAuthor.UseVisualStyleBackColor = true;
            this.buttonRemoveAuthor.Click += new System.EventHandler(this.buttonRemoveAuthor_Click);
            // 
            // buttonEditAuthor
            // 
            this.buttonEditAuthor.Enabled = false;
            this.buttonEditAuthor.Location = new System.Drawing.Point(106, 4);
            this.buttonEditAuthor.Name = "buttonEditAuthor";
            this.buttonEditAuthor.Size = new System.Drawing.Size(100, 34);
            this.buttonEditAuthor.TabIndex = 1;
            this.buttonEditAuthor.Text = "Ändra";
            this.buttonEditAuthor.UseVisualStyleBackColor = true;
            this.buttonEditAuthor.Click += new System.EventHandler(this.buttonEditAuthor_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(0, 4);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(100, 34);
            this.buttonAddAuthor.TabIndex = 0;
            this.buttonAddAuthor.Text = "Lägg till";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // UserControlAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlAuthors";
            this.Size = new System.Drawing.Size(1076, 585);
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
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Födelsedatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Land;
        private System.Windows.Forms.DataGridViewComboBoxColumn Böcker;
        private System.Windows.Forms.Button buttonEditAuthor;
        private System.Windows.Forms.Button buttonRemoveAuthor;
    }
}
