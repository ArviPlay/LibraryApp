using LibraryAppForProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            dataGridView1.Rows.Clear();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Author, Title FROM Books";

                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["Id"], reader["Author"], reader["Title"]);
                    }
                }
            }
        }
    }
}
