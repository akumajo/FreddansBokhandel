namespace FreddansBokhandel
{
    partial class UserControlEmployees
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Butik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anställningsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewEmployees);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditEmployee);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddEmployee);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 585);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Butik,
            this.Telefon,
            this.Email,
            this.Anställningsdatum,
            this.Roll,
            this.Adress,
            this.Postnr,
            this.Postadress});
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1076, 540);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.Text = "dataGridView1";
            // 
            // ID
            // 
            this.ID.FillWeight = 25.38071F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Namn
            // 
            this.Namn.FillWeight = 108.2911F;
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            this.Namn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Butik
            // 
            this.Butik.FillWeight = 108.2911F;
            this.Butik.HeaderText = "Butik";
            this.Butik.Name = "Butik";
            this.Butik.ReadOnly = true;
            this.Butik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Telefon
            // 
            this.Telefon.FillWeight = 108.2911F;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Email
            // 
            this.Email.FillWeight = 108.2911F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Anställningsdatum
            // 
            this.Anställningsdatum.FillWeight = 108.2911F;
            this.Anställningsdatum.HeaderText = "Anställningsdatum";
            this.Anställningsdatum.Name = "Anställningsdatum";
            this.Anställningsdatum.ReadOnly = true;
            this.Anställningsdatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Roll
            // 
            this.Roll.FillWeight = 108.2911F;
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Adress
            // 
            this.Adress.FillWeight = 108.2911F;
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Postnr
            // 
            this.Postnr.FillWeight = 108.2911F;
            this.Postnr.HeaderText = "Postnr";
            this.Postnr.Name = "Postnr";
            this.Postnr.ReadOnly = true;
            this.Postnr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Postadress
            // 
            this.Postadress.FillWeight = 108.2911F;
            this.Postadress.HeaderText = "Postadress";
            this.Postadress.Name = "Postadress";
            this.Postadress.ReadOnly = true;
            this.Postadress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(0, 4);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(100, 34);
            this.buttonAddEmployee.TabIndex = 0;
            this.buttonAddEmployee.Text = "Lägg till";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // button1
            // 
            this.buttonEditEmployee.Enabled = false;
            this.buttonEditEmployee.Location = new System.Drawing.Point(107, 4);
            this.buttonEditEmployee.Name = "button1";
            this.buttonEditEmployee.Size = new System.Drawing.Size(100, 34);
            this.buttonEditEmployee.TabIndex = 1;
            this.buttonEditEmployee.Text = "Ändra";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // UserControlEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlEmployees";
            this.Size = new System.Drawing.Size(1076, 585);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Butik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anställningsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postadress;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
    }
}
