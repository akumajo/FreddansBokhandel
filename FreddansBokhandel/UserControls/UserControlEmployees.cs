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
    public partial class UserControlEmployees : UserControl
    {
        List<Anställda> employees;
        public UserControlEmployees()
        {
            InitializeComponent();
        }

        private void LoadEmployeesFromDatabase()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    employees = db.Anställda.Include(b => b.Butiker).ToList();
                }

                else
                {
                    MessageBox.Show("Kunde inte koppla upp mot databasen.");
                }
            }
        }

        private void PopulateDataGridEmployees()
        {
            dataGridViewEmployees.Rows.Clear();

            foreach (var employee in employees)
            {
                int rowIndex = dataGridViewEmployees.Rows.Add();
                dataGridViewEmployees.Rows[rowIndex].Cells["ID"].Value = employee.Id;
                dataGridViewEmployees.Rows[rowIndex].Cells["Namn"].Value = employee.Förnamn + " " + employee.Efternamn;
                dataGridViewEmployees.Rows[rowIndex].Cells["Butik"].Value = employee.Butiker.Namn;
                dataGridViewEmployees.Rows[rowIndex].Cells["Anställningsdatum"].Value = employee.Anställningsdatum.ToString("yyyy-MM-dd");
                dataGridViewEmployees.Rows[rowIndex].Cells["Roll"].Value = employee.Roll;
                dataGridViewEmployees.Rows[rowIndex].Cells["Email"].Value = employee.Email;
                dataGridViewEmployees.Rows[rowIndex].Cells["Telefon"].Value = employee.Telefon;
                dataGridViewEmployees.Rows[rowIndex].Cells["Adress"].Value = employee.Adress;
                dataGridViewEmployees.Rows[rowIndex].Cells["Postnr"].Value = employee.Postnummer;
                dataGridViewEmployees.Rows[rowIndex].Cells["Postadress"].Value = employee.Postort;
                dataGridViewEmployees.Rows[rowIndex].Tag = employee;
            }
        }

        private void CreateNewEmployee()
        {
            FormAddEmployee newEmployee = new FormAddEmployee(employees.Count);
            newEmployee.ShowDialog();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            CreateNewEmployee();
            LoadEmployeesFromDatabase();
            PopulateDataGridEmployees();
        }

        private void UserControlEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployeesFromDatabase();
            PopulateDataGridEmployees();
        }
    }
}