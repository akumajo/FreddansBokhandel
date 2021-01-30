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
        private int SetAuthorID()
        {
            if (selectedAuthor == null)
            {
                return authors.Count + 1;
            }

            return selectedAuthor.Id;
        }

        public void SetValuesOnEditMode()
        {
            Text = "Ändra författare";
            textBoxFirstName.Text = selectedAuthor.FirstName;
            textBoxLastName.Text = selectedAuthor.LastName;
            textBoxCountry.Text = selectedAuthor.Country;

            if (selectedAuthor.DateOfBirth == null)
            {
                checkBoxUnknownBirthDate.CheckState = CheckState.Checked;
            }
            else
            {
                dateTimePicker1.Value = selectedAuthor.DateOfBirth.Value;
            }
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
                        Id = SetAuthorID(),
                        FirstName = textBoxFirstName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        DateOfBirth = CheckAuthorBirthday(),
                        Country = textBoxCountry.Text.Trim()
                    };

                    if (selectedAuthor == null) { db.Add(newAuthor); }
                    else { db.Update(newAuthor); }

                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }
    }
}