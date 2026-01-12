using System;
using System.IO;
using System.Windows.Forms;

namespace LibraryAppForProject.MenuStripForms
{
    public partial class PopularBooksReportForm : Form
    {
        public PopularBooksReportForm()
        {
            InitializeComponent();
            startdtp.Value = DateTime.Now.AddMonths(-1);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Введите название отчёта для истории!");
                return;
            }
            saveFileDialog1.FileName = nameTextBox.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string dateStart = startdtp.Value.ToString("yyyy-MM-dd");
                string dateEnd = enddtp.Value.ToString("yyyy-MM-dd");
                try
                {
                    int recordsCount = 0;
                    var sb = new System.Text.StringBuilder();
                    sb.AppendLine("Название;Автор;Кол-во выдач");
                    using (var connection = DatabaseHelper.GetConnection())
                    {
                        string sql = $@"
                            SELECT Books.Title, Books.Author, COUNT(Issues.IssueId) as Count
                            FROM Books
                            JOIN Issues ON Books.Id = Issues.BookId
                            WHERE Issues.BorrowDate BETWEEN '{dateStart}' AND '{dateEnd}'
                            GROUP BY Books.Id
                            ORDER BY Count DESC";
                        using (var reader = DatabaseHelper.ExecuteReader(sql, connection))
                        {
                            while (reader.Read())
                            {
                                sb.AppendLine($"{reader["Title"]};{reader["Author"]};{reader["Count"]}");
                                recordsCount++;
                            }
                        }
                        File.WriteAllText(filePath, sb.ToString(), System.Text.Encoding.UTF8);
                        string reportName = nameTextBox.Text.Trim().Replace("'", "''");
                        string periodLog = $"{dateStart} - {dateEnd}";
                        string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        string insertSql = $@"INSERT INTO Reports (Name, Period, GeneratedDate, RecordsCount) 
                            VALUES ('{reportName}', '{periodLog}', '{dateNow}', {recordsCount})";
                        DatabaseHelper.ExecuteNonQuery(insertSql, connection);
                        MessageBox.Show($"Отчет успешно сохранен в файл и в базу данных!", "Успех");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
