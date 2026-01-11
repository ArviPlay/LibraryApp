using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryAppForProject.MenuStripBooks
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
            GetData();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            int id = (int)numericUpDown1.Value;

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = $"SELECT Author, Title FROM Books WHERE Id = {id}";

                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    if (reader.Read())
                    {
                        authorTextBox.Text = reader["Author"].ToString();
                        nameTextBox.Text = reader["Title"].ToString();
                        saveButton.Enabled = true;
                        authorTextBox.Enabled = true;
                        nameTextBox.Enabled = true;
                    }
                    else
                    {
                        authorTextBox.Clear();
                        nameTextBox.Clear();
                        saveButton.Enabled = false;
                        authorTextBox.Enabled = false;
                        nameTextBox.Enabled = false;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Некоторые поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)numericUpDown1.Value;
            string newAuthor = authorTextBox.Text;
            string newTitle = nameTextBox.Text;

            string query = $"UPDATE Books SET Author = '{newAuthor}', Title = '{newTitle}' WHERE Id = {id}";
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    DatabaseHelper.ExecuteNonQuery(query, connection);
                }
                DatabaseHelper.NotifyChanges();
                MessageBox.Show("Данные успешно изменены!");
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
