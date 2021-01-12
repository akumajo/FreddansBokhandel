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
        List<Förlag> publishers;

        public UserControlPublishers()
        {
            InitializeComponent();
        }

        private void UserControlPublishers_Load(object sender, EventArgs e)
        {
            PopulateDataGridPublishers();
        }

        public void PopulateDataGridPublishers()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    dataGridViewPublishers.Rows.Clear();

                    publishers = db.Förlag.ToList();

                    foreach (var publisher in publishers)
                    {
                        int rowIndex = dataGridViewPublishers.Rows.Add();
                        dataGridViewPublishers.Rows[rowIndex].Cells["ID"].Value = publisher.Id;
                        dataGridViewPublishers.Rows[rowIndex].Cells["Namn"].Value = publisher.Namn;
                        dataGridViewPublishers.Rows[rowIndex].Cells["Adress"].Value = publisher.Adress;
                        dataGridViewPublishers.Rows[rowIndex].Cells["Postnr"].Value = publisher.Postnummer;
                        dataGridViewPublishers.Rows[rowIndex].Cells["Postort"].Value = publisher.Postort;
                        dataGridViewPublishers.Rows[rowIndex].Cells["Land"].Value = publisher.Land;
                    }
                }
            }
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            FormAddPublisher newPublisher = new FormAddPublisher(publishers);
            newPublisher.ShowDialog();
            PopulateDataGridPublishers();
        }
    }
}