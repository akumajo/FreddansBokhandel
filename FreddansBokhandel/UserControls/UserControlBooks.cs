using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FreddansBokhandel
{
    public partial class UserControlBooks : UserControl
    {
        int selectedStoreRow = 0;
        private List<Book> books;
        Book selectedBook;
        FreddansBokhandelContext db;

        public UserControlBooks(FormMain form1)
        {
            InitializeComponent();
            form1.LeaveBooksTab += Form1_LeaveTabPage;
            form1.EnterBooksTab += Form1_EnterBooksTab;
        }

        private void LoadBooksFromDatabase()
        {
            db = new FreddansBokhandelContext();
            if (db.Database.CanConnect())
            {
                books = db.Böcker
                     .Include(a => a.BooksAuthors)
                     .ThenInclude(b => b.Author)
                     .Include(b => b.StockBalance)
                     .ThenInclude(b => b.Store)
                     .Include(b => b.Publisher)
                     .Include(o => o.OrderDetails)
                     .ToList();
            }
            else
            {
                MessageBox.Show("Kunde inte koppla upp mot databasen.");
            }
        }

        private void PopulateListBox()
        {
            selectedBook = null;
            listBox1.Items.Clear();

            foreach (var book in books)
            {
                listBox1.Items.Add(book);
            }
        }

        private void AddNewBook()
        {
            selectedBook = null;
            var addBook = new FormAddOrEditBook(books, selectedBook);
            addBook.ShowDialog();
        }

        private void BookIsSelected()
        {
            selectedStoreRow = 0;
            selectedBook = listBox1.SelectedItem as Book;
            EnableButtons();
            ShowBookInfo();
        }

        private void EnableButtons()
        {
            buttonAddBookToStock.Enabled = true;
            buttonUpdateBook.Enabled = true;
            buttonDeleteBook.Enabled = true;
        }

        private void DisableButtons()
        {
            buttonAddBookToStock.Enabled = false;
            buttonUpdateBook.Enabled = false;
            buttonDeleteBook.Enabled = false;
        }

        private void ShowBookInfo()
        {
            textBoxAuthor.Text = null;
            textBoxTitle.Text = selectedBook.Title;
            textBoxPrice.Text = selectedBook.Price.ToString();
            textBoxISBN.Text = selectedBook.Isbn;
            textBoxLanguage.Text = selectedBook.Language;
            textBoxPages.Text = selectedBook.Pages.ToString();
            textBoxFormat.Text = selectedBook.Format;
            textBoxPublisher.Text = selectedBook.Publisher.Name;
            textBoxReleaseDate.Text = selectedBook.ReleaseDate.ToString("yyyy-MM-dd");

            foreach (var author in selectedBook.BooksAuthors)
            {
                textBoxAuthor.Text += $"{author.Author.FirstName} {author.Author.LastName}, ";
            }

            textBoxAuthor.Text = textBoxAuthor.Text.Remove(textBoxAuthor.Text.Length - 2, 2);
            ShowStoreBalance(selectedBook);
        }

        private void ClearBookInfo()
        {
            textBoxAuthor.Text = null;
            textBoxTitle.Text = null;
            textBoxPrice.Text = null;
            textBoxISBN.Text = null;
            textBoxLanguage.Text = null;
            textBoxPages.Text = null;
            textBoxFormat.Text = null;
            textBoxPublisher.Text = null;
            textBoxReleaseDate.Text = null;
            dataGridViewOverview.Rows.Clear();
        }

        private void ShowStoreBalance(Book book)
        {
            dataGridViewOverview.Rows.Clear();

            foreach (var balance in book.StockBalance)
            {
                int rowIndex = dataGridViewOverview.Rows.Add();
                dataGridViewOverview.Rows[rowIndex].Cells["Butik"].Value = balance.Store;
                dataGridViewOverview.Rows[rowIndex].Cells["Antal"].Value = balance.Balance;
                dataGridViewOverview.Rows[rowIndex].Cells["Lagervärde"].Value = (balance.Balance * book.Price).ToString("C");
            }

            dataGridViewOverview.CurrentCell = dataGridViewOverview[0, selectedStoreRow];
        }

        private void UpdateBook()
        {
            var updateBook = new FormAddOrEditBook(books, selectedBook);
            updateBook.ShowDialog();
        }

        private void AddBookToStock()
        {
            selectedStoreRow = dataGridViewOverview.CurrentCell.RowIndex;
            var selectedStore = dataGridViewOverview[0, selectedStoreRow].Value as Store;

            foreach (var item in selectedBook.StockBalance)
            {
                if (selectedStore.Id == item.StoreID)
                { 
                    item.Balance += 1; 
                }  
            }
            db.SaveChanges();
            ShowStoreBalance(selectedBook);
        }

        private void FilterBooks()
        {
            string filter = textBoxFilter.Text;
            listBox1.Items.Clear();
            if (filter != null)
            {
                foreach (var book in books)
                {
                    if (book.Title.ToLower().Contains(filter.Trim().ToLower()))
                    {
                        listBox1.Items.Add(book);
                    }
                }
            }
            else
            {
                foreach (var book in books)
                {
                    listBox1.Items.Add(book);
                }
            }
        }

        private void DeleteBook()
        {
            DialogResult dr = MessageBox.Show("Vill du ta bort den här boken ur systemet?\nObservera att det inte går att ta bort böcker som redan har sålts.", "Ta bort bok", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                var book = listBox1.SelectedItem as Book;

                if (book.OrderDetails.Count > 1)
                {
                    MessageBox.Show($"Boken fanns bland ordrar och kunde inte tas bort.");
                }
                else
                {
                    MessageBox.Show($"Boken togs bort. {book.Isbn}");
                    db.Remove(book);
                    db.SaveChanges();
                    LoadBooksFromDatabase();
                    PopulateListBox();
                }
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void buttonFilterBooks_Click(object sender, EventArgs e)
        {
            FilterBooks();
        }

        private void buttonAddBookToStock_Click(object sender, EventArgs e)
        {
            AddBookToStock();
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookIsSelected();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewBook();
            LoadBooksFromDatabase();
            PopulateListBox();
        }

        private void Form1_EnterBooksTab(object sender, EventArgs e)
        {
            LoadBooksFromDatabase();
            PopulateListBox();
        }

        private void Form1_LeaveTabPage(object sender, EventArgs e)
        {
            DisableButtons();
            ClearBookInfo();
            db.Dispose();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            Class1 img = new Class1(selectedBook.Isbn);
            img.yeah();
        }
    }
}