using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddPublisher : Form
    {
        List<Publisher> publishers;
        public FormAddPublisher(List<Publisher> _publishers)
        {
            InitializeComponent();
            publishers = _publishers;
        }

        private bool DoesPublisherExists()
        {
            foreach (var publisher in publishers)
            {
                if (textBoxName.Text.Trim() == publisher.Name)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckIfNameIsEmpty()
        {
            if (textBoxName.Text.Trim() == "") { return false; }
            return true;
        }

        private void AddPublishers()
        {
            if (DoesPublisherExists() == false) { MessageBox.Show("Författaren finns redan i systemet."); return; }
            if (CheckIfNameIsEmpty() == false) { MessageBox.Show("Namnfältet är tomt. Försök igen."); return; }

            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newPublisher = new Publisher
                    {
                        Id = publishers.Count + 1,
                        Name = textBoxName.Text.Trim(),
                        Address = textBoxAddress.Text.Trim(),
                        ZipCode = textBoxPostNo.Text.Trim(),
                        PostalAddress = textBoxPostalAdress.Text.Trim(),
                        Country = textBoxCountry.Text.Trim()
                    };

                    db.Add(newPublisher);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            AddPublishers();
        }
    }
}