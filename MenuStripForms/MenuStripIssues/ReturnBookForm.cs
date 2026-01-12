using System;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripForms
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
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
            int issueId = (int)numericUpDown1.Value;
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = @"
                    SELECT Clients.Name, Books.Title, Issues.ReturnDate 
                    FROM Issues
                    JOIN Clients ON Issues.ClientId = Clients.Id
                    JOIN Books ON Issues.BookId = Books.Id
                    WHERE Issues.IssueId = " + issueId;
                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    if (reader.Read())
                    {
                        if (reader["ReturnDate"] != DBNull.Value && !string.IsNullOrEmpty(reader["ReturnDate"].ToString()))
                        {
                            infoLabel.Text = "Эта книга уже была возвращена!";
                            returnButton.Enabled = false;
                        }
                        else
                        {
                            infoLabel.Text = $"Клиент: {reader["Name"]}\nКнига: {reader["Title"]}";
                            returnButton.Enabled = true;
                        }
                    }
                    else
                    {
                        infoLabel.Text = "Нет данных";
                        returnButton.Enabled = false;
                    }
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            int issueId = (int)numericUpDown1.Value;
            string returnDate = DateTime.Now.ToString("yyyy-MM-dd");
            string query = $"UPDATE Issues SET ReturnDate = '{returnDate}' WHERE IssueId = {issueId}";
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    DatabaseHelper.ExecuteNonQuery(query, connection);
                }
                DatabaseHelper.NotifyChanges();
                MessageBox.Show("Книга успешно принята!");
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
