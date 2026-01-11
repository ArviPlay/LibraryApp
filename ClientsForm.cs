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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            dataGridView1.Rows.Clear();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Name, Phone, BirthDate FROM Clients";

                using (var reader = DatabaseHelper.ExecuteReader(query, connection))
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["Id"], reader["Name"], reader["Phone"], reader["BirthDate"]);
                    }
                }
            }
        }
    }
}
