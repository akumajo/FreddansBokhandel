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
        List<Förlag> publishers;
        public FormAddPublisher(List<Förlag> _publishers)
        {
            InitializeComponent();
            publishers = _publishers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPublishers();
        }

        private bool DoesPublisherExists()
        {
            foreach (var publisher in publishers)
            {
                if (textBoxName.Text.Trim() == publisher.Namn)
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
                    var newPublisher = new Förlag
                    {
                        Id = publishers.Count + 1,
                        Namn = textBoxName.Text.Trim(),
                        Adress = textBoxAddress.Text.Trim(),
                        Postnummer = textBoxPostNo.Text.Trim(),
                        Postort = textBoxPostalAdress.Text.Trim(),
                        Land = textBoxCountry.Text.Trim()
                    };

                    db.Add(newPublisher);
                    db.SaveChanges();
                    Close();
                }
            }
        }
    }
}