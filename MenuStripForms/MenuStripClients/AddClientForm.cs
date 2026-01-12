using System;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripForms
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(nameTextBox.Text) || !phoneTextBox.MaskCompleted)
            {
                MessageBox.Show("Некоторые поля пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = nameTextBox.Text.Trim().Replace("'", "''");
            string phone = phoneTextBox.Text;
            string birthDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = $@"INSERT INTO Clients (Name, Phone, BirthDate) VALUES('{name}', '{phone}', '{birthDate}')";
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    DatabaseHelper.ExecuteNonQuery(query, connection);
                }
                DatabaseHelper.NotifyChanges();
                MessageBox.Show("Клиент успешно добавлен!");
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
