using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddNewAuthor : Form
    {
        List<Författare> authors;

        public FormAddNewAuthor(List<Författare> _authors)
        {
            InitializeComponent();
            authors = _authors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }

        private bool DoesAuthorExists()
        {
            foreach (var author in authors)
            {
                if (textBoxSurName.Text.Trim() == author.Förnamn && textBoxLastName.Text == author.Efternamn)
                {
                    return true;
                }
            }
            return false;
        }

        private DateTime? CheckAuthorBirthday()
        {
            if (checkBoxUnknownBirthDate.Checked)
            {
                return null;
            }
            else
            {
                return dateTimePicker1.Value;
            }
        }

        private void AddAuthor()
        {
            if (DoesAuthorExists() == true) { MessageBox.Show("Författaren finns redan i systemet."); return; }

            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newAuthor = new Författare
                    {
                        Id = authors.Count + 1,
                        Förnamn = textBoxSurName.Text.Trim(),
                        Efternamn = textBoxLastName.Text.Trim(),
                        Födelsedatum = CheckAuthorBirthday(),
                        Land = textBoxCountry.Text.Trim()
                    };

                    db.Add(newAuthor);
                    db.SaveChanges();
                    Close();
                }
            }
        }
    }
}