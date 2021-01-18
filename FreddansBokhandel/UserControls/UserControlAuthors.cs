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
        }

        private void AddNewAuthor()
        {
            selectedAuthor = null;
            FormAddorEditNewAuthor newAuthor = new FormAddorEditNewAuthor(authors, selectedAuthor);
            newAuthor.ShowDialog();
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

        private void EditAuthor()
        {
            FormAddorEditNewAuthor newAuthor = new FormAddorEditNewAuthor(authors, selectedAuthor);
            newAuthor.ShowDialog();

        }

        private void SelectingARow()
        {
            if (dataGridViewAuthors.CurrentCell == null) { return; }
            if (dataGridViewAuthors.SelectedRows.Count < 1) { return; }

            buttonEditAuthor.Enabled = true;
            int selectedIndex = dataGridViewAuthors.SelectedRows[0].Index;
            selectedAuthor = dataGridViewAuthors.Rows[selectedIndex].Tag as Author;
        }

        private void dataGridViewAuthors_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            SelectingARow();
        }
    }
}