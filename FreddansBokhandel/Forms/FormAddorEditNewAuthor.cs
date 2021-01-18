using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddorEditNewAuthor : Form
    {
        List<Author> authors;
        Author selectedAuthor;

        public FormAddorEditNewAuthor(List<Author> _authors, Author _selectedAuthor)
        {
            InitializeComponent();
            authors = _authors;
            selectedAuthor = _selectedAuthor;

            if (_selectedAuthor != null)
            {
                SetValuesOnEditMode();
            }
        }

        public void SetValuesOnEditMode()
        {
            Text = "Ändra författare";
            textBoxFirstName.Text = selectedAuthor.FirstName;
            textBoxLastName.Text = selectedAuthor.LastName;
            dateTimePicker1.Value = selectedAuthor.DateOfBirth.Value;
            textBoxCountry.Text = selectedAuthor.Country;
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
                if (textBoxFirstName.Text.Trim() == author.FirstName && textBoxLastName.Text == author.LastName)
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
                        FirstName = textBoxFirstName.Text.Trim(),
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

        private void EditAuthor()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newAuthor = new Author
                    {
                        Id = selectedAuthor.Id,
                        FirstName = textBoxFirstName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        DateOfBirth = CheckAuthorBirthday(),
                        Country = textBoxCountry.Text.Trim()
                    };

                    db.Update(newAuthor);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedAuthor == null)
            {
                AddAuthor();
            }
            EditAuthor();
        }
    }
}