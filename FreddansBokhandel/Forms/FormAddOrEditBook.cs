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

        private bool CheckIfBookCanBeAdded()
        {
            Regex reg = new Regex("^[0-9]+$");

            if (textBoxISBN.TextLength != 13 || reg.IsMatch(textBoxISBN.Text) == false)
            {
                MessageBox.Show("ISBN är inte ett giltigt format.");
                return false;
            }
            if (selectedBook == null)
            {
                foreach (var book in books)
                {
                    if (book.Isbn == textBoxISBN.Text)
                    {
                        MessageBox.Show($"En bok med ISBN {textBoxISBN.Text} existerar redan i databasen.");
                        return false;
                    }
                }
            }
            if (comboBoxFormat.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja ett format.");
                return false;
            }
            if (comboBoxLanguage.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja ett språk.");
                return false;
            }
            if (comboBoxPublisher.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja ett förlag.");
                return false;
            }
            if (textBoxTitle.Text.Trim() == "")
            {
                MessageBox.Show("Boken måste ha en titel.");
                return false;
            }
            if (textBoxPrice.Text == null || reg.IsMatch(textBoxPrice.Text) == false)
            {
                MessageBox.Show("'Pris' har felaktigt format.");
                return false;
            }
            if (textBoxPages.Text == null || reg.IsMatch(textBoxPages.Text) == false)
            {
                MessageBox.Show("'Sidor' har felaktigt format.");
                return false;
            }
            if (comboBoxAuthor.SelectedItem == null && comboBoxAuthor2.SelectedItem == null && comboBoxAuthor3.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja minst en författare.");
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

                for (int i = 0; i < stores.Count; i++)
                {
                    var saldo = new StockBalance { StoreID = i + 1, Balance = 0, Isbn = newBook.Isbn };

                    if (selectedBook == null) { db.Add(saldo); }
                    else { db.Update(saldo); }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (authors[i] != null)
                    {
                        var bookAndAuthor = new BooksAuthors { Isbn = newBook.Isbn, AuthorId = authors[i].Id };

                        if (selectedBook == null) { db.Add(bookAndAuthor); }
                        else { db.Update(bookAndAuthor); }
                    }
                }

                db.SaveChanges();
                db.Dispose();
                Close();
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