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
        private List<Book> books;
        private List<Store> stores;
        private List<Order> orders;
        private FreddansBokhandelContext db;
        List<Book> booksInCart = new List<Book>();

        public FormAddNewOrder()
        {
            InitializeComponent();
        }

        private Store SelectedStore()
        {
            return comboBoxStores.SelectedItem as Store;
        }

        private Book SelectedBook()
        {
            return listBoxBooks.SelectedItem as Book;
        }

        private Employee SelectedEmployee()
        {
            return comboBoxSeller.SelectedItem as Employee;
        }

        private DateTime SetShippingDate()
        {
            if (SelectedStore().Id == 1)
            {
                return DateTime.MinValue;
            }
            return dateTimePicker1.Value;
        }

        private void CreateNewOrderID()
        {
            foreach (var item in orders)
            {
                textBoxOrderID.Text = $"{item.Id + 1}";
            }
        }

        private bool CheckIfBookIsInStock()
        {
            foreach (var balance in SelectedBook().StockBalance)
            {
                if (SelectedStore().Id == balance.StoreID)
                {
                    if (balance.Balance < 1) { MessageBox.Show("Den här boken finns inte i lager i den valda butiken."); return false; }
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
                if (textBoxFirstName.Text.Trim() == "") { return false; }
                if (textBoxLastName.Text.Trim() == "") { return false; }
                if (textBoxAdress.Text.Trim() == "") { return false; }
                if (textBoxPostalAddress.Text.Trim() == "") { return false; }
                if (textBoxCountry.Text.Trim() == "") { return false; }
                if (textBoxZipCode.Text.Trim() == "") { return false; }
            }
            return true;
        }

        private void CreateNewOrder()
        {
            Order newOrder = null;
            if (SelectedStore().Id == 1)
            {
                newOrder = new Order
                {
                    Id = Convert.ToInt32(textBoxOrderID.Text),
                    EmployeeID = SelectedEmployee().Id,
                    StoreID = SelectedStore().Id,
                    OrderDate = dateTimePicker1.Value,
                    SentDate = SetShippingDate(),
                    RecipientFirstName = textBoxFirstName.Text.Trim(),
                    RecipientLastName = textBoxLastName.Text.Trim(),
                    RecipientZipCode = textBoxZipCode.Text.Trim(),
                    RecipientAddress = textBoxAdress.Text.Trim(),
                    RecipientPostalAddress = textBoxPostalAddress.Text.Trim(),
                    RecipientCountry = textBoxCountry.Text.Trim()
                };
            }
            else
            {
                newOrder = new Order
                {
                    Id = Convert.ToInt32(textBoxOrderID.Text),
                    EmployeeID = SelectedEmployee().Id,
                    StoreID = SelectedStore().Id,
                    OrderDate = dateTimePicker1.Value,
                    SentDate = SetShippingDate()
                };
            }
            db.Add(newOrder);
        }

        private void CreateOrderDetails()
        {
            var sortedBooks = booksInCart.OrderBy(t => t.Title).ToList();

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

                var newOrderDetails = new OrderDetail
                {
                    Id = $"{textBoxOrderID.Text}/{j + 1}",
                    OrderId = Convert.ToInt32(textBoxOrderID.Text),
                    Isbn = sortedBooks[j].Isbn,
                    Price = sortedBooks[j].Price,
                    Quantity = quantity
                };

                db.Add(newOrderDetails);
            }

            db.SaveChanges();
        }

        private void EnableCustomerDetails()
        {
            textBoxAdress.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxPostalAddress.Enabled = true;
            textBoxFirstName.Enabled = true;
            textBoxZipCode.Enabled = true;
            textBoxCountry.Enabled = true;
        }

        private void DisableCustomerDetails()
        {
            textBoxAdress.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxPostalAddress.Enabled = false;
            textBoxFirstName.Enabled = false;
            textBoxZipCode.Enabled = false;
            textBoxCountry.Enabled = false;
        }

        private void ClearCustomerDetails()
        {
            textBoxAdress.Text = null;
            textBoxLastName.Text = null;
            textBoxPostalAddress.Text = null;
            textBoxFirstName.Text = null;
            textBoxZipCode.Text = null;
            textBoxCountry.Text = null;
        }

        private void LoadFromDatabase()
        {
            db = new FreddansBokhandelContext();

            if (db.Database.CanConnect())
            {
                listBoxBooks.Items.Clear();

                books = db.Böcker
                     .Include(a => a.BooksAuthors)
                     .ThenInclude(b => b.Author)
                     .Include(b => b.StockBalance)
                     .ThenInclude(b => b.Store)
                     .Include(b => b.Publisher)
                     .Include(o => o.OrderDetails)
                     .ToList();

                stores = db.Butiker
                    .Include(ls => ls.StockBalance)
                    .ThenInclude(s => s.IsbnNavigation)
                    .Include(a => a.Employees)
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
            foreach (var employee in SelectedStore().Employees)
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

            foreach (var balance in SelectedBook().StockBalance)
            {
                if (SelectedStore().Id == balance.StoreID)
                {
                    labelAmount.Text = balance.Balance.ToString();
                }
            }
        }

        private void AddToCart()
        {
            if (SelectedBook() == null) { return; }
            if (CheckIfBookIsInStock() == false) { return; }

            listBoxCart.Items.Add(SelectedBook());
            booksInCart.Add(SelectedBook());

            foreach (var balance in SelectedBook().StockBalance)
            {
                if (SelectedStore().Id == balance.StoreID)
                {
                    balance.Balance = balance.Balance - 1;
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