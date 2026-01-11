using LibraryAppForProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            dataGridView1.Rows.Clear();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Name, Period, GeneratedDate, RecordsCount FROM Reports";

                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["Id"], reader["Name"], reader["Period"], reader["GeneratedDate"], reader["RecordsCount"]);
                    }
                }
            }
        }
    }
}
