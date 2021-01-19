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

        public UserControlPublishers(FormMain form)
        {
            InitializeComponent();
            form.EnterPublishersTab += Form_EnterPublishersTab;
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

                db.Dispose();
            }
        }

        private void PopulateDataGridPublishers()
        {
            dataGridViewPublishers.Rows.Clear();

            if (publishers == null) { return; }

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

            buttonEditPublisher.Enabled = true;
        }

        private void AddNewPublisher()
        {
            FormAddPublisher newPublisher = new FormAddPublisher(publishers, selectedPublisher);
            newPublisher.ShowDialog();
        }

        private void EditPublisher()
        {
            selectedPublisher = dataGridViewPublishers.SelectedRows[0].Tag as Publisher;
            FormAddPublisher newPublisher = new FormAddPublisher(publishers, selectedPublisher);
            newPublisher.ShowDialog();
            selectedPublisher = null;
        }

        private void Form_EnterPublishersTab(object sender, EventArgs e)
        {
            LoadPublishersFromDatabase();
            PopulateDataGridPublishers();
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            AddNewPublisher();
            LoadPublishersFromDatabase();
            PopulateDataGridPublishers();
        }

        private void buttonEditPublisher_Click(object sender, EventArgs e)
        {
            EditPublisher();
            LoadPublishersFromDatabase();
            PopulateDataGridPublishers();
        }
    }
}