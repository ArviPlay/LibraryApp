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
    public partial class DeleteClientForm : Form
    {
        public DeleteClientForm()
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
                string query = $"SELECT Name, Phone, BirthDate FROM Clients WHERE Id = {id}";
                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    if (reader.Read())
                    {
                        nameLabel.Text = reader["Name"].ToString();
                        phoneLabel.Text = reader["Phone"].ToString();
                        birthDateLabel.Text = reader["BirthDate"].ToString();
                        deleteButton.Enabled = true;
                    }
                    else
                    {
                        nameLabel.Text = "Нет данных";
                        phoneLabel.Text = "Нет данных";
                        birthDateLabel.Text = "Нет данных";
                        deleteButton.Enabled = false;
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int clientId = (int)numericUpDown1.Value;
            using (var connection = DatabaseHelper.GetConnection())
            {
                string checkSql = $"SELECT COUNT(*) FROM Issues WHERE ClientId = {clientId}";
                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkSql, connection));
                if (count > 0)
                {
                    MessageBox.Show("Нельзя удалить клиента, так как в журнале есть записи о выдаче книг этому человеку. ", "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого клиента? Это действие нельзя отменить.", "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = (int)numericUpDown1.Value;
                string query = $"DELETE FROM Clients WHERE Id = {id}";
                try
                {
                    using (var connection = DatabaseHelper.GetConnection())
                    {
                        DatabaseHelper.ExecuteNonQuery(query, connection);
                    }
                    DatabaseHelper.NotifyChanges();
                    MessageBox.Show("Клиент успешно удалён.");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении: " + ex.Message);
                }
            }
        }
    }
}
