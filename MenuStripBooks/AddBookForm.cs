using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripBooks
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Некоторые поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string author = authorTextBox.Text.Trim().Replace("'", "''");
            string title = nameTextBox.Text.Trim().Replace("'", "''");

            string query = $"INSERT INTO Books (Author, Title) VALUES ('{author}', '{title}')";

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    DatabaseHelper.ExecuteNonQuery(query, connection);
                }

                DatabaseHelper.NotifyChanges();
                MessageBox.Show("Книга успешно добавлена!");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
