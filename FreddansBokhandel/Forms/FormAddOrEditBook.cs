using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace FreddansBokhandel
{
    public partial class FormAddOrEditBook : Form
    {
        private List<Book> books;
        private List<Store> stores;
        private Book selectedBook;
        private FreddansBokhandelContext db = new FreddansBokhandelContext();
        private object remove;
        private object remove2;
        private object remove3;

        public FormAddOrEditBook(List<Book> _books, Book _selectedBook)
        {
            InitializeComponent();
            books = _books;
            selectedBook = _selectedBook;

            if (selectedBook != null)
            {
                this.Text = "Ändra bok";
            }

        }

        private void InsertBookInfoFromSelectedBook()
        {
            List<string> selectedBookAuthors = new List<string>();

            textBoxISBN.Enabled = false;
            textBoxPrice.Text = selectedBook.Price.ToString();
            textBoxPages.Text = selectedBook.Pages.ToString();
            textBoxTitle.Text = selectedBook.Title;
            textBoxISBN.Text = selectedBook.Isbn;
            dateTimePicker1.Value = selectedBook.ReleaseDate;
            comboBoxLanguage.SelectedIndex = comboBoxLanguage.FindString(selectedBook.Language);
            comboBoxFormat.SelectedIndex = comboBoxFormat.FindString(selectedBook.Format);
            comboBoxPublisher.SelectedIndex = comboBoxPublisher.FindString(selectedBook.Publisher.Name);

            foreach (var item in selectedBook.BooksAuthors)
            {
                selectedBookAuthors.Add($"{item.Author.FirstName} {item.Author.LastName}");
            }

            comboBoxAuthor.SelectedIndex = comboBoxAuthor.FindString($"{selectedBookAuthors[0]}");

            if (selectedBookAuthors.Count > 1)
            {
                comboBoxAuthor2.SelectedIndex = comboBoxAuthor.FindString($"{selectedBookAuthors[1]}");
            }

            if (selectedBookAuthors.Count > 2)
            {
                comboBoxAuthor3.SelectedIndex = comboBoxAuthor.FindString($"{selectedBookAuthors[2]}");
            }
        }

        private bool CheckTextBoxesWithRegex()
        {
            Regex reg = new Regex("^[0-9]+$");

            if (textBoxISBN.TextLength != 13 || reg.IsMatch(textBoxISBN.Text) == false) { return false; }
            if (reg.IsMatch(textBoxPrice.Text) == false) { return false; }
            if (reg.IsMatch(textBoxPages.Text) == false) { return false; }

            return true;
        }

        private bool CheckIfTextBoxesAreEmpty()
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text))) { return false; }
            return true;
        }

        private bool CheckIfComboBoxesAreNull()
        {
            if (comboBoxFormat.SelectedItem == null) { return false; }
            if (comboBoxLanguage.SelectedItem == null) { return false; }
            if (comboBoxPublisher.SelectedItem == null) { return false; }
            if (comboBoxAuthor.SelectedItem == null && comboBoxAuthor2.SelectedItem == null
                && comboBoxAuthor3.SelectedItem == null) { return false; }
            return true;
        }

        private bool CheckIfISBNExists()
        {
            if (selectedBook == null)
            {
                foreach (var book in books)
                {
                    if (book.Isbn == textBoxISBN.Text) { return false; }
                }
            }
            return true;
        }

        private bool CheckIfBookCanBeAdded()
        {
            if (CheckIfISBNExists() == false)
            {
                MessageBox.Show($"En bok med ISBN {textBoxISBN.Text} existerar redan i databasen.");
                return false;
            }

            if (CheckIfComboBoxesAreNull() == false)
            {
                MessageBox.Show($"Ett eller flera fält är tomma.");
                return false;
            }

            if (CheckIfTextBoxesAreEmpty() == false)
            {
                MessageBox.Show($"Ett eller flera fält är tomma.");
                return false;
            }

            if (CheckTextBoxesWithRegex() == false)
            {
                MessageBox.Show($"Ett eller flera fält är inte korrekt ifyllda.");
                return false;
            }

            return true;
        }

        private void PopulateComboboxes()
        {
            string[] bookFormat = { "Häftad", "Inbunden", "Pocket", "Spiral" };
            string[] languages = { "Arabiska", "Engelska", "Japanska", "Ryska", "Spanska", "Svenska" };
            comboBoxFormat.Items.AddRange(bookFormat);
            comboBoxLanguage.Items.AddRange(languages);

            if (db.Database.CanConnect())
            {
                var authors = db.Författare.ToList();
                var publishers = db.Förlag.ToList();
                stores = db.Butiker.ToList();

                foreach (var author in authors)
                {
                    comboBoxAuthor.Items.Add(author);
                    comboBoxAuthor2.Items.Add(author);
                    comboBoxAuthor3.Items.Add(author);
                }

                foreach (var publisher in publishers)
                {
                    comboBoxPublisher.Items.Add(publisher);
                }
            }
        }

        private void AddBookToDatabase()
        {
            if (CheckIfBookCanBeAdded())
            {
                var authors = ComboboxAuthors();
                var newBook = CreateBook();

                if (selectedBook != null)
                {
                    UpdateBookAndAuthorJT(authors, newBook, selectedBook);
                }
                else
                {
                    AddBookAndAuthorJT(authors, newBook);
                }

                db.SaveChanges();
                db.Dispose();
                Close();
            }
        }

        private void AddBookAndAuthorJT(List<Author> authors, Book newBook)
        {
            for (int i = 0; i < 3; i++)
            {
                if (authors[i] != null)
                {
                    var bookAndAuthor = new BooksAuthors { Isbn = newBook.Isbn, AuthorId = authors[i].Id };
                    db.Add(bookAndAuthor);
                }
            }

            for (int i = 0; i < stores.Count; i++)
            {
                var saldo = new StockBalance { StoreID = i + 1, Balance = 0, Isbn = newBook.Isbn };
                db.Add(saldo);
            }
        }

        private void UpdateBookAndAuthorJT(List<Author> authors, Book newBook, Book selectedBook)
        {
            foreach (var book in selectedBook.BooksAuthors)
            {
                var bookAndAuthor = new BooksAuthors { Isbn = book.Isbn, AuthorId = book.AuthorId };
                db.Remove(bookAndAuthor);
                db.SaveChanges();
            }

            for (int i = 0; i < 3; i++)
            {
                if (authors[i] != null)
                {
                    var bookAndAuthor = new BooksAuthors { Isbn = newBook.Isbn, AuthorId = authors[i].Id };
                    db.Add(bookAndAuthor);
                }
            }
        }

        private List<Author> ComboboxAuthors()
        {
            List<Author> authors = new List<Author>();
            authors.Add(comboBoxAuthor.SelectedItem as Author);
            authors.Add(comboBoxAuthor2.SelectedItem as Author);
            authors.Add(comboBoxAuthor3.SelectedItem as Author);

            return authors;
        }

        private Book CreateBook()
        {
            var publisher = comboBoxPublisher.SelectedItem as Publisher;
            var newBook = new Book
            {
                Isbn = textBoxISBN.Text,
                Title = textBoxTitle.Text.Trim(),
                Language = comboBoxLanguage.SelectedItem.ToString(),
                Price = Convert.ToInt32(textBoxPrice.Text),
                ReleaseDate = dateTimePicker1.Value,
                Pages = Convert.ToInt32(textBoxPages.Text),
                Format = comboBoxFormat.SelectedItem.ToString(),
                PublisherId = publisher.Id
            };

            if (selectedBook == null) { db.Add(newBook); }
            else { db.Update(newBook); }

            return newBook;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();

            if (selectedBook != null)
            {
                InsertBookInfoFromSelectedBook();
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBookToDatabase();
        }

        private void buttonRemoveAuthor1_Click(object sender, EventArgs e)
        {
            if (remove != null)
            {
                comboBoxAuthor2.Items.Add(remove);
                comboBoxAuthor3.Items.Add(remove);
                remove = null;
            }
            comboBoxAuthor.SelectedItem = null;
        }

        private void buttonRemoveAuthor2_Click(object sender, EventArgs e)
        {
            if (remove2 != null)
            {
                comboBoxAuthor.Items.Add(remove2);
                comboBoxAuthor3.Items.Add(remove2);
                remove2 = null;
            }
            comboBoxAuthor2.SelectedItem = null;
        }

        private void buttonRemoveAuthor3_Click(object sender, EventArgs e)
        {
            if (remove3 != null)
            {
                comboBoxAuthor.Items.Add(remove3);
                comboBoxAuthor2.Items.Add(remove3);
                remove3 = null;
            }
            comboBoxAuthor3.SelectedItem = null;
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove = comboBoxAuthor.SelectedItem;
            comboBoxAuthor2.Items.Remove(remove);
            comboBoxAuthor3.Items.Remove(remove);
        }

        private void comboBoxAuthor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove2 = comboBoxAuthor2.SelectedItem;
            comboBoxAuthor.Items.Remove(remove2);
            comboBoxAuthor3.Items.Remove(remove2);
        }

        private void comboBoxAuthor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove3 = comboBoxAuthor3.SelectedItem;
            comboBoxAuthor.Items.Remove(remove3);
            comboBoxAuthor2.Items.Remove(remove3);
        }
    }
}