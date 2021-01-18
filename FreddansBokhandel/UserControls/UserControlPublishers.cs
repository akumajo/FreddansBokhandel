using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FreddansBokhandel
{
    public partial class UserControlPublishers : UserControl
    {
        List<Publisher> publishers;
        Publisher selectedPublisher;

        public UserControlPublishers()
        {
            InitializeComponent();
        }

        private void LoadPublishersFromDatabase()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    publishers = db.Förlag.ToList();
                }

                else
                {
                    MessageBox.Show("Kunde inte koppla upp mot databasen.");
                }
            }
        }

        private void PopulateDataGridPublishers()
        {
            dataGridViewPublishers.Rows.Clear();

            foreach (var publisher in publishers)
            {
                int rowIndex = dataGridViewPublishers.Rows.Add();
                dataGridViewPublishers.Rows[rowIndex].Cells["ID"].Value = publisher.Id;
                dataGridViewPublishers.Rows[rowIndex].Cells["Namn"].Value = publisher.Name;
                dataGridViewPublishers.Rows[rowIndex].Cells["Adress"].Value = publisher.Address;
                dataGridViewPublishers.Rows[rowIndex].Cells["Postnr"].Value = publisher.ZipCode;
                dataGridViewPublishers.Rows[rowIndex].Cells["Postort"].Value = publisher.PostalAddress;
                dataGridViewPublishers.Rows[rowIndex].Cells["Land"].Value = publisher.Country;
                dataGridViewPublishers.Rows[rowIndex].Tag = publisher;
            }
        }

        private void AddNewPublishers()
        {
            selectedPublisher = null;
            FormAddPublisher newPublisher = new FormAddPublisher(publishers, selectedPublisher);
            newPublisher.ShowDialog();
        }

        private void UserControlPublishers_Load(object sender, EventArgs e)
        {
            LoadPublishersFromDatabase();
            PopulateDataGridPublishers();
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            AddNewPublishers();
            LoadPublishersFromDatabase();
            PopulateDataGridPublishers();
        }

        private void buttonEditPublisher_Click(object sender, EventArgs e)
        {
            EditEmployee();
            LoadPublishersFromDatabase();
            PopulateDataGridPublishers();
        }
        private void EditEmployee()
        {
            FormAddPublisher newPublisher = new FormAddPublisher(publishers, selectedPublisher);
            newPublisher.ShowDialog();
        }

        private void SelectingARow()
        {
            if (dataGridViewPublishers.CurrentCell == null) { return; }
            if (dataGridViewPublishers.SelectedRows.Count < 1) { return; }

            buttonEditPublisher.Enabled = true;
            int selectedIndex = dataGridViewPublishers.SelectedRows[0].Index;
            selectedPublisher = dataGridViewPublishers.Rows[selectedIndex].Tag as Publisher;
        }

        private void dataGridViewPublishers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            SelectingARow();
        }
    }
}