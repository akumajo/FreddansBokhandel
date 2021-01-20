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
        Publisher selectedPublisher;

        public FormAddPublisher(List<Publisher> _publishers, Publisher _selectedPublisher)
        {
            InitializeComponent();
            publishers = _publishers;
            selectedPublisher = _selectedPublisher;

            if(selectedPublisher != null)
            {
                Text = "Ändra förlag";
                SetValuesOnEditMode();
            }
        }

        private int SetPublisherID()
        {
            if (selectedPublisher == null)
            {
                return publishers.Count + 1;
            }

            return selectedPublisher.Id;
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

        private void SetValuesOnEditMode()
        {
            textBoxName.Text = selectedPublisher.Name;
            textBoxAddress.Text = selectedPublisher.Address;
            textBoxZipCode.Text = selectedPublisher.ZipCode;
            textBoxPostalAdress.Text = selectedPublisher.PostalAddress;
            textBoxCountry.Text = selectedPublisher.Country;
        }

        private void AddorEditPublishers()
        {
            if (DoesPublisherExists() == false && selectedPublisher == null) { MessageBox.Show("Författaren finns redan i systemet."); return; }
            if (CheckIfNameIsEmpty() == false) { MessageBox.Show("Namnfältet är tomt. Försök igen."); return; }

            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newPublisher = new Publisher
                    {
                        Id = SetPublisherID(),
                        Name = textBoxName.Text.Trim(),
                        Address = textBoxAddress.Text.Trim(),
                        ZipCode = textBoxZipCode.Text.Trim(),
                        PostalAddress = textBoxPostalAdress.Text.Trim(),
                        Country = textBoxCountry.Text.Trim()
                    };

                    if (selectedPublisher == null) { db.Add(newPublisher); }
                    else { db.Update(newPublisher); }

                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            AddorEditPublishers();
        }
    }
}