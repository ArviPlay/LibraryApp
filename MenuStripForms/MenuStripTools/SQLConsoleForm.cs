using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripForms
{
    public partial class SQLConsoleForm : Form
    {
        public SQLConsoleForm()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string query = codeTextBox.Text.Trim();
            if (string.IsNullOrEmpty(query)) return;
            dataGridView1.DataSource = null;
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (query.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        DatabaseHelper.ExecuteNonQuery(query, connection);
                        MessageBox.Show("Команда выполнена успешно!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            codeTextBox.Clear();
            dataGridView1.DataSource = null;
        }
    }
}
