using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddNewAuthor : Form
    {
        List<Author> authors;

        public FormAddNewAuthor(List<Author> _authors)
        {
            InitializeComponent();
            authors = _authors;
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

        private bool DoesAuthorExists()
        {
            foreach (var author in authors)
            {
                if (textBoxSurName.Text.Trim() == author.FirstName && textBoxLastName.Text == author.LastName)
                {
                    return true;
                }
            }
            return false;
        }

        private void AddAuthor()
        {
            if (DoesAuthorExists() == true) { MessageBox.Show("Författaren finns redan i systemet."); return; }

            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newAuthor = new Author
                    {
                        Id = authors.Count + 1,
                        FirstName = textBoxSurName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        DateOfBirth = CheckAuthorBirthday(),
                        Country = textBoxCountry.Text.Trim()
                    };

                    db.Add(newAuthor);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }
    }
}