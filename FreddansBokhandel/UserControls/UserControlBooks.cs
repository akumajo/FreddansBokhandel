using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

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

        private async Task LoadBooksFromDatabaseAsync()
        {
            db = new FreddansBokhandelContext();

            try
            {
                if (db.Database.CanConnect())
                {
                    books = await db.Böcker
                         .Include(a => a.BooksAuthors)
                         .ThenInclude(b => b.Author)
                         .Include(b => b.StockBalance)
                         .ThenInclude(b => b.Store)
                         .Include(b => b.Publisher)
                         .Include(o => o.OrderDetails)
                         .Include(i => i.Image)
                         .ToListAsync();
                }
                else
                {
                    MessageBox.Show("Kunde inte koppla upp mot databasen.");
                }
            }

            catch
            {
                return;
            }
        }

        private void PopulateListBox()
        {
            if (books == null) return;

            selectedBook = null;
            buttonLoadImage.BringToFront();
            listBox1.Items.Clear();

            foreach (var book in books)
            {
                listBox1.Items.Add(book);
            }
        }

        private void FetchImageFromWeb()
        {
            WebScraperLite img = new WebScraperLite(selectedBook.Isbn);
            img.SaveImageToDatabase();
        }

        private void BookIsSelected()
        {
            selectedStoreRow = 0;
            selectedBook = listBox1.SelectedItem as Book;
            EnableButtons();
            ShowBookInfo();
        }

        private void LoadImage()
        {
            if (selectedBook.Image == null)
            {
                pictureBox1.Image = null;
                buttonLoadImage.BringToFront();
                return;
            }

            byte[] imageSource = selectedBook.Image.ImageArray;
            Bitmap image;

            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                image = new Bitmap(stream);
            }

            pictureBox1.Image = image;
            buttonLoadImage.SendToBack();
        }

        private void EnableButtons()
        {
            buttonAddBookToStock.Enabled = true;
            buttonUpdateBook.Enabled = true;
            buttonDeleteBook.Enabled = true;
            buttonLoadImage.Enabled = true;
        }

        private void DisableButtons()
        {
            buttonAddBookToStock.Enabled = false;
            buttonUpdateBook.Enabled = false;
            buttonDeleteBook.Enabled = false;
            buttonLoadImage.Enabled = false;
        }

        private void ShowBookInfo()
        {
            LoadImage();
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
            pictureBox1.Image = null;
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
        }

        private void AddNewBook()
        {
            selectedBook = null;
            var addBook = new FormAddOrEditBook(books, selectedBook);
            addBook.ShowDialog();
        }

        private void EditBook()
        {
            var updateBook = new FormAddOrEditBook(books, selectedBook);
            updateBook.ShowDialog();
        }

        private async Task DeleteBookAsync()
        {
            DialogResult dr = MessageBox.Show("Vill du ta bort den här boken ur systemet?\nObservera att det inte går att ta bort böcker som redan har sålts.", "Ta bort bok", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                var book = listBox1.SelectedItem as Book;

                if (book.OrderDetails.Count > 0)
                {
                    MessageBox.Show($"Boken fanns bland ordrar och kunde inte tas bort.");
                }
                else
                {
                    MessageBox.Show($"Boken togs bort. {book.Isbn}");
                    db.Remove(book.Image);
                    db.SaveChanges();
                    db.Remove(book);
                    db.SaveChanges();

                    await LoadBooksFromDatabaseAsync();
                    PopulateListBox();
                }
            }
        }

        private void AddBookToStock()
        {
            if (selectedBook == null) { return; }

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

        private async void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            await DeleteBookAsync();
        }

        private void buttonFilterBooks_Click(object sender, EventArgs e)
        {
            FilterBooks();
        }

        private void buttonAddBookToStock_Click(object sender, EventArgs e)
        {
            AddBookToStock();
        }

        private async void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            EditBook();
            await LoadBooksFromDatabaseAsync();
            PopulateListBox();
            ClearBookInfo();
            DisableButtons();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookIsSelected();
        }

        private async void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewBook();
            await LoadBooksFromDatabaseAsync();
            PopulateListBox();
            ClearBookInfo();
            DisableButtons();
        }

        private async void Form1_EnterBooksTab(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            await LoadBooksFromDatabaseAsync();
            PopulateListBox();
        }

        private void Form1_LeaveTabPage(object sender, EventArgs e)
        {
            DisableButtons();
            ClearBookInfo();
            if (db != null) { db.Dispose(); }
        }

        private async void buttonLoadImage_Click(object sender, EventArgs e)
        {
            buttonLoadImage.Enabled = false;
            FetchImageFromWeb();
            await LoadBooksFromDatabaseAsync();
            PopulateListBox();
            ShowBookInfo();
        }
    }
}