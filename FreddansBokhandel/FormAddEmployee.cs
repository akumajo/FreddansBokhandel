using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddEmployee : Form
    {
        int numberOfEmployees = 0;
        List<Butiker> stores;
        public FormAddEmployee(int _numberOfEmployees)
        {
            InitializeComponent();
            numberOfEmployees = _numberOfEmployees;
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            PopulateRoleComboBox();
            PopulateStoreComboBox();
        }

        private void PopulateRoleComboBox()
        {
            string[] roles = { "Butikschef", "Personal", "Inköpare" };
            comboBoxRole.Items.AddRange(roles);
        }

        private void PopulateStoreComboBox()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    stores = db.Butiker.ToList();
                }
            }
            foreach (var store in stores)
            {
                comboBoxStores.Items.Add(store);
            }
        }

        private bool CheckIfEmployeeCanBeAdded()
        {
            if (textBoxSurName.Text.Trim() == "") { return false; }
            if (textBoxLastName.Text.Trim() == "") { return false; }
            if (dateTimePicker1.Value == null) { return false; }
            if (textBoxAddress.Text.Trim() == "") { return false; }
            if (textBoxPostalNo.Text.Trim() == "") { return false; }
            if (textBoxPostAddress.Text.Trim() == "") { return false; }
            if (textBoxEmail.Text.Trim() == "") { return false; }
            if (textBoxTelephone.Text.Trim() == "") { return false; }
            if (comboBoxRole.SelectedItem == null) { return false; }
            if (comboBoxStores.SelectedItem == null) { return false; }
            if (EmailIsValid(textBoxEmail.Text.Trim()) == false) { return false; }

            return true;
        }

        private bool EmailIsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }

        private void AddNewEmployee()
        {
            var store = comboBoxStores.SelectedItem as Butiker;

            if (CheckIfEmployeeCanBeAdded() == false) { MessageBox.Show("Ett eller flera fält är tomma. Fyll i och försök igen."); return; }

            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newEmployee = new Anställda
                    {
                        Id = numberOfEmployees + 1,
                        Förnamn = textBoxSurName.Text.Trim(),
                        Efternamn = textBoxLastName.Text.Trim(),
                        Födelsedatum = dateTimePicker1.Value,
                        Adress = textBoxAddress.Text.Trim(),
                        Postnummer = textBoxPostalNo.Text.Trim(),
                        Postort = textBoxPostAddress.Text.Trim(),
                        Anställningsdatum = dateTimePicker2.Value,
                        Email = textBoxEmail.Text.Trim(),
                        Telefon = textBoxTelephone.Text.Trim(),
                        Butik = store.Id,
                        Roll = comboBoxRole.SelectedItem.ToString()
                    };

                    db.Add(newEmployee);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '-')
            {
                if (e.KeyChar != '\b')
                {
                    e.Handled = !char.IsNumber(e.KeyChar);
                }
            }
        }

        
    }
}
