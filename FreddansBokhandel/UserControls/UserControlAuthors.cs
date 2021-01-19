using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FreddansBokhandel
{
    public partial class UserControlAuthors : UserControl
    {
        List<Author> authors;
        Author selectedAuthor;

        public UserControlAuthors(FormMain form)
        {
            InitializeComponent();
            form.EnterAuthorsTab += Form_EnterAuthorsTab;
        }

        private void Form_EnterAuthorsTab(object sender, EventArgs e)
        {
            dataGridViewAuthors.CurrentCell = null;
            LoadAuthorsFromDatabase();
            PopulateDataGridAuthors();
        }

        private string ReturnAuthorBirthdate(Author author)
        {
            if (author.DateOfBirth == null) { return "-"; }
            return Convert.ToDateTime(author.DateOfBirth).ToShortDateString();
        }

        private void LoadAuthorsFromDatabase()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    authors = db.Författare.Include(b => b.BooksAuthors)
                        .ThenInclude(i => i.IsbnNavigation)
                        .ToList();
                }
                else
                {
                    MessageBox.Show("Kunde inte koppla upp mot databasen.");
                }

                db.Dispose();
            }
        }

        private void PopulateDataGridAuthors()
        {
            dataGridViewAuthors.Rows.Clear();

            if (authors == null) { return; }

            foreach (var author in authors)
            {
                int rowIndex = dataGridViewAuthors.Rows.Add();
                var comboBoxCell = dataGridViewAuthors.Rows[rowIndex].Cells["Böcker"] as DataGridViewComboBoxCell;

                dataGridViewAuthors.Rows[rowIndex].Cells["ID"].Value = author.Id;
                dataGridViewAuthors.Rows[rowIndex].Cells["Namn"].Value = $"{author.FirstName} {author.LastName}";
                dataGridViewAuthors.Rows[rowIndex].Cells["Land"].Value = author.Country;
                dataGridViewAuthors.Rows[rowIndex].Cells["Födelsedatum"].Value = ReturnAuthorBirthdate(author);
                dataGridViewAuthors.Rows[rowIndex].Tag = author;

                foreach (var book in author.BooksAuthors)
                {
                    comboBoxCell.Items.Add(book.IsbnNavigation.Title);
                }

                comboBoxCell.ToolTipText = $"{comboBoxCell.Items.Count} stycken böcker i sortimentet";
            }
            buttonEditAuthor.Enabled = true;
        }

        private void AddNewAuthor()
        {
            FormAddorEditNewAuthor newAuthor = new FormAddorEditNewAuthor(authors, selectedAuthor);
            newAuthor.ShowDialog();
        }

        private void EditAuthor()
        {
            selectedAuthor = dataGridViewAuthors.SelectedRows[0].Tag as Author;
            FormAddorEditNewAuthor newAuthor = new FormAddorEditNewAuthor(authors, selectedAuthor);
            newAuthor.ShowDialog();
            selectedAuthor = null;
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            AddNewAuthor();
            LoadAuthorsFromDatabase();
            PopulateDataGridAuthors();
        }

        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            EditAuthor();
            LoadAuthorsFromDatabase();
            PopulateDataGridAuthors();
        }

        
    }
}