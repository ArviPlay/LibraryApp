using System;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripForms
{
    public partial class EditClientForm : Form
    {
        public EditClientForm()
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
                        nameTextBox.Text = reader["Name"].ToString();
                        phoneTextBox.Text = reader["Phone"].ToString();
                        if (DateTime.TryParse(reader["BirthDate"].ToString(), out DateTime bDate))
                        {
                            dateTimePicker1.Value = bDate;
                        }
                        saveButton.Enabled = true;
                        nameTextBox.Enabled = true;
                        phoneTextBox.Enabled = true;
                        dateTimePicker1.Enabled = true;
                    }
                    else
                    {
                        nameTextBox.Clear();
                        phoneTextBox.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                        saveButton.Enabled = false;
                        nameTextBox.Enabled = false;
                        phoneTextBox.Enabled = false;
                        dateTimePicker1.Enabled = false;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || !phoneTextBox.MaskCompleted)
            {
                MessageBox.Show("Некоторые поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)numericUpDown1.Value;
            string name = nameTextBox.Text.Trim().Replace("'", "''");
            string phone = phoneTextBox.Text;
            string birthDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string query = $@"UPDATE Clients SET Name = '{name}', Phone = '{phone}', BirthDate = '{birthDate}' WHERE Id = {id}";
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
