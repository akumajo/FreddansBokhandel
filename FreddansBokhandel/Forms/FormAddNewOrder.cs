using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FreddansBokhandel
{
    public partial class FormAddNewOrder : Form
    {
        private List<Böcker> books;
        private List<Butiker> stores;
        private List<Ordrar> orders;
        private FreddansBokhandelContext db;
        List<Böcker> booksInCart = new List<Böcker>();

        public FormAddNewOrder()
        {
            InitializeComponent();
        }

        private Butiker SelectedStore()
        {
            return comboBoxStores.SelectedItem as Butiker;
        }

        private Böcker SelectedBook()
        {
            return listBoxBooks.SelectedItem as Böcker;
        }

        private Anställda SelectedEmployee()
        {
            return comboBoxSeller.SelectedItem as Anställda;
        }

        private DateTime SetShippingDate()
        {
            if (SelectedStore().Id == 1)
            {
                return DateTime.MinValue;
            }
            return dateTimePicker1.Value;
        }

        private bool CheckIfBookIsInStock()
        {
            foreach (var balance in SelectedBook().Lagersaldo)
            {
                if (SelectedStore().Id == balance.ButikId)
                {
                    if (balance.Antal < 1) { MessageBox.Show("Den här boken finns inte i lager i den valda butiken."); return false; }
                }
            }
            return true;
        }

        private bool CheckIfOrderCanBeCreated()
        {
            if (booksInCart.Count < 1) { return false; }
            if (SelectedEmployee() == null) { return false; }

            if (SelectedStore().Id == 1)
            {
                if (textBoxSurName.Text.Trim() == null) { return false; }
                if (textBoxLastName.Text.Trim() == null) { return false; }
                if (textBoxAdress.Text.Trim() == null) { return false; }
                if (textBoxPostalAdress.Text.Trim() == null) { return false; }
                if (textBoxCountry.Text.Trim() == null) { return false; }
                if (textBoxPostalNumber.Text.Trim() == null) { return false; }
            }
            return true;
        }

        private void CreateNewOrder()
        {
            Ordrar newOrder = null;
            if (SelectedStore().Id == 1)
            {
                newOrder = new Ordrar
                {
                    Id = Convert.ToInt32(textBoxOrderID.Text),
                    AnställningsId = SelectedEmployee().Id,
                    ButikId = SelectedStore().Id,
                    Beställningsdatum = dateTimePicker1.Value,
                    SkickatDatum = SetShippingDate(),
                    MottagareFörnamn = textBoxSurName.Text.Trim(),
                    MottagareEfternamn = textBoxLastName.Text.Trim(),
                    MottagarePostnummer = textBoxPostalNumber.Text.Trim(),
                    MottagareAdress = textBoxAdress.Text.Trim(),
                    MottagarePostort = textBoxPostalAdress.Text.Trim(),
                    MottagareLand = textBoxCountry.Text.Trim()
                };
            }
            else
            {
                newOrder = new Ordrar
                {
                    Id = Convert.ToInt32(textBoxOrderID.Text),
                    AnställningsId = SelectedEmployee().Id,
                    ButikId = SelectedStore().Id,
                    Beställningsdatum = dateTimePicker1.Value,
                    SkickatDatum = SetShippingDate()
                };
            }
            db.Add(newOrder);
        }

        private void CreateOrderDetails()
        {
            var sortedBooks = booksInCart.OrderBy(t => t.Titel).ToList();

            for (int j = 0; j < sortedBooks.Count; j++)
            {
                int quantity = 1;
                for (int i = j; i < sortedBooks.Count - 1; i++)
                {
                    if (sortedBooks[j] == sortedBooks[i + 1])
                    {
                        quantity++;
                        j++;
                    }
                }

                var newOrderDetails = new Orderhuvud
                {
                    Id = $"{textBoxOrderID.Text}/{j + 1}",
                    OrderId = Convert.ToInt32(textBoxOrderID.Text),
                    Isbn = sortedBooks[j].Isbn,
                    Pris = sortedBooks[j].Pris,
                    Kvantitet = quantity
                };

                db.Add(newOrderDetails);
            }

            db.SaveChanges();
        }

        private void EnableCustomerDetails()
        {
            textBoxAdress.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxPostalAdress.Enabled = true;
            textBoxSurName.Enabled = true;
            textBoxPostalNumber.Enabled = true;
        }

        private void DisableCustomerDetails()
        {
            textBoxAdress.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxPostalAdress.Enabled = false;
            textBoxSurName.Enabled = false;
            textBoxPostalNumber.Enabled = false;
        }

        private void ClearCustomerDetails()
        {
            textBoxAdress.Text = null;
            textBoxLastName.Text = null;
            textBoxPostalAdress.Text = null;
            textBoxSurName.Text = null;
            textBoxPostalNumber.Text = null;
        }

        private void LoadFromDatabase()
        {
            db = new FreddansBokhandelContext();

            if (db.Database.CanConnect())
            {
                listBoxBooks.Items.Clear();

                books = db.Böcker
                     .Include(a => a.BöckerFörfattare)
                     .ThenInclude(b => b.Författare)
                     .Include(b => b.Lagersaldo)
                     .ThenInclude(b => b.Butik)
                     .Include(b => b.Förlag)
                     .Include(o => o.Orderhuvud)
                     .ToList();

                stores = db.Butiker
                    .Include(ls => ls.LagerSaldo)
                    .ThenInclude(s => s.IsbnNavigation)
                    .Include(a => a.Anställda)
                    .ToList();

                orders = db.Ordrar.ToList();
            }
        }

        private void AddBooksToListBox()
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book);
            }
        }

        private void AddEmployeesToComboBox()
        {
            comboBoxSeller.Items.Clear();
            foreach (var employee in SelectedStore().Anställda)
            {
                comboBoxSeller.Items.Add(employee);
            }
        }

        private void AddStoresToComboBox()
        {
            foreach (var item in stores)
            {
                comboBoxStores.Items.Add(item);
            }
        }

        private void UpdateBalance()
        {
            if (SelectedBook() == null) { return; }

            foreach (var balance in SelectedBook().Lagersaldo)
            {
                if (SelectedStore().Id == balance.ButikId)
                {
                    labelAmount.Text = balance.Antal.ToString();
                }
            }
        }

        private void CreateNewOrderID()
        {
            foreach (var item in orders)
            {
                textBoxOrderID.Text = $"{item.Id + 1}";
            }
        }

        private void AddToCart()
        {
            if (SelectedBook() == null) { return; }
            if (CheckIfBookIsInStock() == false) { return; }

            listBoxCart.Items.Add(SelectedBook());
            booksInCart.Add(SelectedBook());

            foreach (var balance in SelectedBook().Lagersaldo)
            {
                if (SelectedStore().Id == balance.ButikId)
                {
                    balance.Antal = balance.Antal - 1;
                }
            }

            UpdateBalance();
        }

        private void ResetCart()
        {
            if (booksInCart.Count == 0) { return; }
            ClearCustomerDetails();

            listBoxCart.Items.Clear();
            booksInCart.Clear();

            db.Dispose();
            LoadFromDatabase();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();
            AddStoresToComboBox();
            CreateNewOrderID();
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStore() == null) { return; }
            UpdateBalance();
        }

        private void comboBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStore().Id == 1)
            {
                EnableCustomerDetails();
            }
            else
            {
                DisableCustomerDetails();
            }

            ResetCart();
            AddEmployeesToComboBox();
            AddBooksToListBox();
            UpdateBalance();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (CheckIfOrderCanBeCreated() == true)
            {
                CreateNewOrder();
                CreateOrderDetails();
                db.Dispose();
                Close();
            }
            else
            {
                MessageBox.Show("Något eller några fält är tomma.");
            }
        }

        private void buttonResetCart_Click(object sender, EventArgs e)
        {
            ResetCart();
            AddBooksToListBox();
        }
    }
}