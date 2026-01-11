using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripBooks
{
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
            GetData();
        }
        private void GetData()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string clientQuery = "SELECT Id, Name FROM Clients";
                using (var reader = DatabaseHelper.ExecuteReader(clientQuery, connection))
                {
                    while (reader.Read())
                    {
                        clientComboBox.Items.Add(new { Text = reader["Name"].ToString(), Value = reader["Id"].ToString() });
                    }
                }
                clientComboBox.DisplayMember = "Text";
                clientComboBox.ValueMember = "Value";
                string bookQuery = "SELECT Id, Title FROM Books";
                using (var reader = DatabaseHelper.ExecuteReader(bookQuery, connection))
                {
                    while (reader.Read())
                    {
                        bookComboBox.Items.Add(new { Text = reader["Title"].ToString(), Value = reader["Id"].ToString() });
                    }
                }
                bookComboBox.DisplayMember = "Text";
                bookComboBox.ValueMember = "Value";
            }
            dueBookdtp.Value = DateTime.Now.AddDays(14);
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedItem == null || bookComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента и книгу!");
                return;
            }
            dynamic selectedClient = clientComboBox.SelectedItem;
            dynamic selectedBook = bookComboBox.SelectedItem;
            int clientId = Convert.ToInt32(selectedClient.Value);
            int bookId = Convert.ToInt32(selectedBook.Value);
            string borrowDate = borrowBookdtp.Value.ToString("yyyy-MM-dd");
            string dueDate = dueBookdtp.Value.ToString("yyyy-MM-dd");
            string query = $@"INSERT INTO Issues (ClientId, BookId, BorrowDate, DueDate, ReturnDate) VALUES ({clientId}, {bookId}, '{borrowDate}', '{dueDate}', NULL)";
            try
            {
                using(var connection = DatabaseHelper.GetConnection())
                {
                    DatabaseHelper.ExecuteNonQuery(query, connection);
                }
                DatabaseHelper.NotifyChanges();
                MessageBox.Show("Книга успешно выдана!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
