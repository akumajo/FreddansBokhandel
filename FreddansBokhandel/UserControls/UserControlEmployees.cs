using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FreddansBokhandel
{
    public partial class UserControlEmployees : UserControl
    {
        List<Employee> employees;
        Employee selectedEmployee;
        public UserControlEmployees(FormMain form)
        {
            InitializeComponent();
            form.EnterEmployeesTab += Form_EnterEmployeesTab;
        }

        

        private void LoadEmployeesFromDatabase()
        {
            using (var db = new FreddansBokhandelContext())
            {
                try
                {
                    if (db.Database.CanConnect())
                    {
                        employees = db.Anställda.Include(b => b.Stores).Include(o => o.Orders).ToList();
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

                db.Dispose();
            }
        }

        private void PopulateDataGridEmployees()
        {
            dataGridViewEmployees.Rows.Clear();

            if (employees == null) { return; }

            foreach (var employee in employees)
            {
                int rowIndex = dataGridViewEmployees.Rows.Add();
                dataGridViewEmployees.Rows[rowIndex].Cells["ID"].Value = employee.Id;
                dataGridViewEmployees.Rows[rowIndex].Cells["Namn"].Value = employee.FirstName + " " + employee.LastName;
                dataGridViewEmployees.Rows[rowIndex].Cells["Butik"].Value = employee.Stores.Name;
                dataGridViewEmployees.Rows[rowIndex].Cells["Anställningsdatum"].Value = employee.HireDate.ToString("yyyy-MM-dd");
                dataGridViewEmployees.Rows[rowIndex].Cells["Roll"].Value = employee.Role;
                dataGridViewEmployees.Rows[rowIndex].Cells["Email"].Value = employee.Email;
                dataGridViewEmployees.Rows[rowIndex].Cells["Telefon"].Value = employee.Telephone;
                dataGridViewEmployees.Rows[rowIndex].Cells["Adress"].Value = employee.Address;
                dataGridViewEmployees.Rows[rowIndex].Cells["Postnr"].Value = employee.ZipCode;
                dataGridViewEmployees.Rows[rowIndex].Cells["Postadress"].Value = employee.PostalAdress;
                dataGridViewEmployees.Rows[rowIndex].Cells["Ordrar"].Value = employee.Orders.Count();
                dataGridViewEmployees.Rows[rowIndex].Tag = employee;
            }
            buttonEditEmployee.Enabled = true;
        }

        private void AddNewEmployee()
        {
            FormAddorEditEmployee newEmployee = new FormAddorEditEmployee(employees, selectedEmployee);
            newEmployee.ShowDialog();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
            LoadEmployeesFromDatabase();
            PopulateDataGridEmployees();
        }
        private void EditEmployee()
        {
            selectedEmployee = dataGridViewEmployees.SelectedRows[0].Tag as Employee;
            FormAddorEditEmployee newEmployee = new FormAddorEditEmployee(employees, selectedEmployee);
            newEmployee.ShowDialog();
            selectedEmployee = null;
        }

        private void Form_EnterEmployeesTab(object sender, EventArgs e)
        {
            LoadEmployeesFromDatabase();
            PopulateDataGridEmployees();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee();
            LoadEmployeesFromDatabase();
            PopulateDataGridEmployees();
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
            LoadEmployeesFromDatabase();
            PopulateDataGridEmployees();
        }

        private void RemoveEmployee()
        {
            DialogResult dr = MessageBox.Show("Vill du ta bort den här anställda ur systemet?\nObservera att det inte går att ta bort anställda som har sålt böcker.", "Ta bort anställd", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                var employee = dataGridViewEmployees.SelectedRows[0].Tag as Employee;

                if (employee.Orders.Count > 0)
                {
                    MessageBox.Show($"Den anställde har ordrar kopplade till sig och kunde inte tas bort.");
                }
                else
                {
                    using (var db = new FreddansBokhandelContext())
                    {
                        if (db.Database.CanConnect())
                        {
                            db.Remove(employee);
                            db.SaveChanges();
                        }

                        else
                        {
                            MessageBox.Show("Kunde inte koppla upp mot databasen.");
                        }

                        db.Dispose();
                    }
                }
            }
        }
    }
}