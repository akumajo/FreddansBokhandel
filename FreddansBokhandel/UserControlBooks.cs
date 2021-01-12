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
        private List<Böcker> books;
        Böcker selectedBook;
        FreddansBokhandelContext db;

        public UserControlBooks(FormMain form1)
        {
            InitializeComponent();
            form1.LeaveBooksTab += Form1_LeaveTabPage;
            form1.EnterBooksTab += Form1_EnterBooksTab;
        }

        private void Form1_EnterBooksTab(object sender, EventArgs e)
        {
            LoadFromDatabase();
            PopulateListBox();
        }

        private void Form1_LeaveTabPage(object sender, EventArgs e)
        {
            DisableButtons();
            ClearBookInfo();
            db.Dispose();
        }
        public void LoadFromDatabase()
        {
            db = new FreddansBokhandelContext();
            if (db.Database.CanConnect())
            {
                books = db.Böcker
                     .Include(a => a.BöckerFörfattare)
                     .ThenInclude(b => b.Författare)
                     .Include(b => b.Lagersaldo)
                     .ThenInclude(b => b.Butik)
                     .Include(b => b.Förlag)
                     .Include(o => o.Orderhuvud)
                     .ToList();
            }
        }
        public void PopulateListBox()
        {
            selectedBook = null;
            listBox1.Items.Clear();

            foreach (var book in books)
            {
                listBox1.Items.Add(book);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            selectedBook = null;
            var addBook = new FormAddOrEditBook(books, selectedBook);
            addBook.ShowDialog();
            LoadFromDatabase();
            PopulateListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStoreRow = 0;
            selectedBook = listBox1.SelectedItem as Böcker;
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
            textBoxTitle.Text = selectedBook.Titel;
            textBoxPrice.Text = selectedBook.Pris.ToString();
            textBoxISBN.Text = selectedBook.Isbn;
            textBoxLanguage.Text = selectedBook.Språk;
            textBoxPages.Text = selectedBook.AntalSidor.ToString();
            textBoxFormat.Text = selectedBook.Format;
            textBoxPublisher.Text = selectedBook.Förlag.Namn;
            textBoxReleaseDate.Text = selectedBook.Utgivningsdatum.ToString("yyyy-MM-dd");

            foreach (var author in selectedBook.BöckerFörfattare)
            {
                textBoxAuthor.Text += $"{author.Författare.Förnamn} {author.Författare.Efternamn}, ";
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

        private void ShowStoreBalance(Böcker book)
        {
            dataGridViewOverview.Rows.Clear();

            foreach (var balance in book.Lagersaldo)
            {
                int rowIndex = dataGridViewOverview.Rows.Add();
                dataGridViewOverview.Rows[rowIndex].Cells["Butik"].Value = balance.Butik;
                dataGridViewOverview.Rows[rowIndex].Cells["Antal"].Value = balance.Antal;
                dataGridViewOverview.Rows[rowIndex].Cells["Lagervärde"].Value = (balance.Antal * book.Pris).ToString("C");
            }

            dataGridViewOverview.CurrentCell = dataGridViewOverview[0, selectedStoreRow];
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            var updateBook = new FormAddOrEditBook(books, selectedBook);
            updateBook.ShowDialog();
        }

        private void buttonAddBookToStock_Click(object sender, EventArgs e)
        {
            selectedStoreRow = dataGridViewOverview.CurrentCell.RowIndex;
            var selectedStore = dataGridViewOverview[0, selectedStoreRow].Value as Butiker;

            foreach (var item in selectedBook.Lagersaldo)
            {
                if (selectedStore.Id == item.ButikId)
                    item.Antal += 1;
            }
            db.SaveChanges();
            ShowStoreBalance(selectedBook);
        }

        private void buttonFilterBooks_Click(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text;
            listBox1.Items.Clear();
            if (filter != null)
            {
                foreach (var book in books)
                {
                    if (book.Titel.ToLower().Contains(filter.Trim().ToLower()))
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

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Vill du ta bort den här boken ur systemet?\nObservera att det inte går att ta bort böcker som redan har sålts.", "Ta bort bok", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                var book = listBox1.SelectedItem as Böcker;

                if (book.Orderhuvud.Count > 1)
                {
                    MessageBox.Show($"Boken fanns bland ordrar och kunde inte tas bort.");
                }
                else
                {
                    MessageBox.Show($"Boken togs bort. {book.Isbn}");
                    db.Remove(book);
                    db.SaveChanges();
                    LoadFromDatabase();
                    PopulateListBox();
                }
            }
        }
    }
}