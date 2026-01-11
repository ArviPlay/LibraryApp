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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
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
                        authorLabel.Text = reader["Author"].ToString();
                        titleLabel.Text = reader["Title"].ToString();
                        deleteButton.Enabled = true;
                    }
                    else
                    {
                        authorLabel.Text = "Нет данных";
                        titleLabel.Text = "Нет данных";
                        deleteButton.Enabled = false;
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int bookId = (int)numericUpDown1.Value;
            using (var connection = DatabaseHelper.GetConnection())
            {
                string checkSql = $"SELECT COUNT(*) FROM Issues WHERE BookId = {bookId}";
                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkSql, connection));
                if (count > 0)
                {
                    MessageBox.Show("Нельзя удалить книгу, так как она числится в журнале выдач. ", "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту книгу? Это действие нельзя отменить.", "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = (int)numericUpDown1.Value;
                string query = $"DELETE FROM Books WHERE Id = {id}";
                try
                {
                    using(var connection = DatabaseHelper.GetConnection())
                    {
                        DatabaseHelper.ExecuteNonQuery(query, connection);
                    }
                    DatabaseHelper.NotifyChanges();
                    MessageBox.Show("Книга успешно удалена.");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении: " + ex.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
