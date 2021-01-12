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

        private void UserControlEmployees_Load(object sender, EventArgs e)
        {
            PopulateDataGridEmployees();
        }

        public void PopulateDataGridEmployees()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    dataGridViewEmployees.Rows.Clear();

                    employees = db.Anställda
                         .Include(b => b.Butiker)
                         .ToList();

                    foreach (var balance in employees)
                    {
                        int rowIndex = dataGridViewEmployees.Rows.Add();
                        dataGridViewEmployees.Rows[rowIndex].Cells["ID"].Value = balance.Id;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Namn"].Value = balance.Förnamn + " " + balance.Efternamn;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Butik"].Value = balance.Butiker.Namn;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Anställningsdatum"].Value = balance.Anställningsdatum.ToString("yyyy-MM-dd");
                        dataGridViewEmployees.Rows[rowIndex].Cells["Roll"].Value = balance.Roll;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Email"].Value = balance.Email;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Telefon"].Value = balance.Telefon;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Adress"].Value = balance.Adress;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Postnr"].Value = balance.Postnummer;
                        dataGridViewEmployees.Rows[rowIndex].Cells["Postadress"].Value = balance.Postort;
                        dataGridViewEmployees.Rows[rowIndex].Tag = balance;
                    }
                }
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee newEmployee = new FormAddEmployee(employees.Count);
            newEmployee.ShowDialog();
            PopulateDataGridEmployees();
        }
    }
}
