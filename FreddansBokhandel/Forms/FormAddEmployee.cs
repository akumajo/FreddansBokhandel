using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddEmployee : Form
    {
        int numberOfEmployees = 0;
        List<Store> stores;
        public FormAddEmployee(int _numberOfEmployees)
        {
            InitializeComponent();
            numberOfEmployees = _numberOfEmployees;
        }

        private bool CheckIfEmployeeCanBeAdded()
        {
            Regex reg = new Regex("^[0-9]+$");

            if (textBoxSurName.Text.Trim() == "") { return false; }
            if (textBoxLastName.Text.Trim() == "") { return false; }
            if (dateTimePicker1.Value == null) { return false; }
            if (textBoxAddress.Text.Trim() == "") { return false; }
            if (textBoxPostalNo.Text.Trim() == "") { return false; }
            if (textBoxPostAddress.Text.Trim() == "") { return false; }
            if (textBoxEmail.Text.Trim() == "") { return false; }
            if (textBoxTelephone.Text.Trim() == "" || reg.IsMatch(textBoxTelephone.Text) == false) { return false; }
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

        private void AddNewEmployee()
        {

            var store = comboBoxStores.SelectedItem as Store;

            if (CheckIfEmployeeCanBeAdded() == false) { MessageBox.Show("Ett eller flera fält är tomma eller i fel format. Försök igen."); return; }


            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newEmployee = new Employee
                    {
                        Id = numberOfEmployees + 1,
                        FirstName = textBoxSurName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        DateOfBirth = dateTimePicker1.Value,
                        Address = textBoxAddress.Text.Trim(),
                        ZipCode = textBoxPostalNo.Text.Trim(),
                        PostalAdress = textBoxPostAddress.Text.Trim(),
                        HireDate = dateTimePicker2.Value,
                        Email = textBoxEmail.Text.Trim(),
                        Telephone = textBoxTelephone.Text.Trim(),
                        Store = store.Id,
                        Role = comboBoxRole.SelectedItem.ToString()
                    };

                    db.Add(newEmployee);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            PopulateRoleComboBox();
            PopulateStoreComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }
    }
}