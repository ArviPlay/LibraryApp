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
    public partial class IssuedBooksForm : Form
    {
        public IssuedBooksForm()
        {
            InitializeComponent();
            LoadIssues();
        }

        private void LoadIssues()
        {
            dataGridView1.Rows.Clear();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT i.IssueId, i.ClientId, c.Name, i.BookId, b.Title, i.BorrowDate, i.DueDate, i.ReturnDate FROM Issues i " +
                    "JOIN Clients c ON i.ClientId = c.Id " +
                    "JOIN Books b ON i.BookId = b.Id";

                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["IssueId"], reader["ClientId"], reader["Name"], reader["BookId"], reader["Title"], reader["BorrowDate"], reader["DueDate"], reader["ReturnDate"]);
                    }
                }
            }
        }
    }
}
