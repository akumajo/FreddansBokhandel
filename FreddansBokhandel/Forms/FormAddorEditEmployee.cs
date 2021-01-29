using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FreddansBokhandel
{
    public partial class FormAddorEditEmployee : Form
    {
        private List<Store> stores;
        private Employee selectedEmployee;
        private int employeeCount;

        public FormAddorEditEmployee(List<Employee> employees, Employee _selectedEmployee)
        {
            InitializeComponent();
            selectedEmployee = _selectedEmployee;
            employeeCount = employees.Count;

            if (selectedEmployee != null)
            {
                Text = "Ändra anställd";
            }
        }

        private int SetEmployeeID()
        {
            if (selectedEmployee == null)
            {
                return employeeCount + 1;
            }

            return selectedEmployee.Id;
        }

        private bool CheckIfEmployeeCanBeAdded()
        {
            if (CheckIfTextBoxesAreEmpty() == false) { return false; }
            if (CheckIfPhoneNumberIsValid() == false) { return false; }
            if (CheckIfComboBoxesAndDateAreEmpty() == false) { return false; }
            if (CheckIfEmailIsValid() == false) { return false; }

            return true;
        }

        private bool CheckIfTextBoxesAreEmpty()
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                return false;
            }

            return true;
        }

        private bool CheckIfPhoneNumberIsValid()
        {
            Regex reg = new Regex("^[0-9]+$");
            if (reg.IsMatch(textBoxTelephone.Text) == false) { return false; }

            return true;
        }

        private bool CheckIfComboBoxesAndDateAreEmpty()
        {
            if (comboBoxRole.SelectedItem == null) { return false; }
            if (comboBoxStores.SelectedItem == null) { return false; }
            if (dateTimePicker1.Value == null) { return false; }
            return true;
        }

        private bool CheckIfEmailIsValid()
        {
            try
            {
                MailAddress m = new MailAddress(textBoxEmail.Text.Trim());

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

        private void SetValuesOnEditMode()
        {
            textBoxFirstName.Text = selectedEmployee.FirstName;
            textBoxLastName.Text = selectedEmployee.LastName;
            dateTimePicker1.Value = selectedEmployee.DateOfBirth;
            textBoxAddress.Text = selectedEmployee.Address;
            textBoxZipCode.Text = selectedEmployee.ZipCode;
            textBoxPostAddress.Text = selectedEmployee.PostalAdress;
            dateTimePicker2.Value = selectedEmployee.HireDate;
            textBoxEmail.Text = selectedEmployee.Email;
            textBoxTelephone.Text = selectedEmployee.Telephone;
            comboBoxRole.SelectedIndex = comboBoxRole.FindString(selectedEmployee.Role);
            comboBoxStores.SelectedIndex = comboBoxStores.FindString(selectedEmployee.Stores.Name);
        }

        private void AddOrEditEmployee()
        {
            var store = comboBoxStores.SelectedItem as Store;

            if (CheckIfEmployeeCanBeAdded() == false) { MessageBox.Show("Ett eller flera fält är tomma eller i fel format. Försök igen."); return; }


            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newEmployee = new Employee
                    {
                        Id = SetEmployeeID(),
                        FirstName = textBoxFirstName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        DateOfBirth = dateTimePicker1.Value,
                        Address = textBoxAddress.Text.Trim(),
                        ZipCode = textBoxZipCode.Text.Trim(),
                        PostalAdress = textBoxPostAddress.Text.Trim(),
                        HireDate = dateTimePicker2.Value,
                        Email = textBoxEmail.Text.Trim(),
                        Telephone = textBoxTelephone.Text.Trim(),
                        Store = store.Id,
                        Role = comboBoxRole.SelectedItem.ToString()
                    };

                    if (selectedEmployee == null) { db.Add(newEmployee); }
                    else { db.Update(newEmployee); }

                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            PopulateRoleComboBox();
            PopulateStoreComboBox();

            if (selectedEmployee != null)
            {
                SetValuesOnEditMode();
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddOrEditEmployee();
        }
    }
}