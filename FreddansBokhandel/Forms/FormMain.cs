using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormMain : Form
    {
        public event EventHandler EnterBooksTab;
        public event EventHandler LeaveBooksTab;

        public event EventHandler EnterOrdersTab;
        public event EventHandler LeaveOrdersTab;

        public FormMain()
        {
            InitializeComponent();
        }

        private void tabPageOrders_Enter(object sender, EventArgs e)
        {
            var order = new UserControlOrders(this) { Dock = DockStyle.Fill };
            tabPageOrders.Controls.Add(order);
            EnterOrdersTab?.Invoke(this, null);
        }

        private void tabPageBooks_Enter(object sender, EventArgs e)
        {
            var books = new UserControlBooks(this) { Dock = DockStyle.Fill };
            tabPageBooks.Controls.Add(books);
            EnterBooksTab?.Invoke(this, null);
        }

        private void tabPageEmployees_Enter(object sender, EventArgs e)
        {
            var employees = new UserControlEmployees() { Dock = DockStyle.Fill };
            tabPageEmployees.Controls.Add(employees);
        }

        private void tabPagePublishers_Enter(object sender, EventArgs e)
        {
            var publisher = new UserControlPublishers() { Dock = DockStyle.Fill };
            tabPagePublishers.Controls.Add(publisher);
        }

        private void tabPageAuthors_Enter(object sender, EventArgs e)
        {
            var authors = new UserControlAuthors() { Dock = DockStyle.Fill };
            tabPageAuthors.Controls.Add(authors);
        }

        private void tabPageBooks_Leave(object sender, EventArgs e)
        {
            LeaveBooksTab?.Invoke(this, null);
        }

        private void tabPageOrders_Leave(object sender, EventArgs e)
        {
            LeaveOrdersTab?.Invoke(this, null);
        }
    }
}