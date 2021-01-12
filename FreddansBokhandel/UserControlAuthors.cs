using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FreddansBokhandel
{
    public partial class UserControlAuthors : UserControl
    {
        List<Författare> authors;

        public UserControlAuthors()
        {
            InitializeComponent();
        }
        
        private void UserControlAuthors_Load(object sender, EventArgs e)
        {
            PopulateDataGridAuthors();
        }

        public void PopulateDataGridAuthors()
        {
            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    dataGridViewAuthors.Rows.Clear();

                    authors = db.Författare.ToList();

                    foreach (var author in authors)
                    {
                        int rowIndex = dataGridViewAuthors.Rows.Add();
                        dataGridViewAuthors.Rows[rowIndex].Cells["ID"].Value = author.Id;
                        dataGridViewAuthors.Rows[rowIndex].Cells["Namn"].Value = $"{author.Förnamn} {author.Efternamn}";
                        if (author.Födelsedatum == null)
                        {
                            dataGridViewAuthors.Rows[rowIndex].Cells["Födelsedatum"].Value = "-";
                        }
                        else
                        {
                            dataGridViewAuthors.Rows[rowIndex].Cells["Födelsedatum"].Value = Convert.ToDateTime(author.Födelsedatum).ToShortDateString();
                        }
                        dataGridViewAuthors.Rows[rowIndex].Cells["Land"].Value = author.Land;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAddNewAuthor newAuthor = new FormAddNewAuthor(authors);
            newAuthor.ShowDialog();

            PopulateDataGridAuthors();
        }

       
    }
}