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

        public UserControlAuthors()
        {
            InitializeComponent();
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

                foreach (var book in author.BooksAuthors)
                {
                    comboBoxCell.Items.Add(book.IsbnNavigation.Title);
                }

                comboBoxCell.ToolTipText = $"{comboBoxCell.Items.Count} stycken böcker i sortimentet";
            }
        }

        private void AddNewAuthor()
        {
            FormAddNewAuthor newAuthor = new FormAddNewAuthor(authors);
            newAuthor.ShowDialog();
        }

        private void UserControlAuthors_Load(object sender, EventArgs e)
        {
            LoadAuthorsFromDatabase();
            PopulateDataGridAuthors();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            AddNewAuthor();
            LoadAuthorsFromDatabase();
            PopulateDataGridAuthors();
        }
    }
}