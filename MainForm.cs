using LibraryAppForProject;
using LibraryAppForProject.MenuStripBooks;
using System;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseHelper.Initialize();
            DatabaseHelper.OnDatabaseChanged += UpdateStatusBar;
            UpdateStatusBar();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateAndTimeLabel.Text = DateTime.Now.ToString("f");
            timer1.Enabled = true;
        }

        private void booksListButton_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
        }

        private void clientsListButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateAndTimeLabel.Text = DateTime.Now.ToString("f");
        }

        private void issuedBooksListButton_Click(object sender, EventArgs e)
        {
            IssuedBooksForm issuedBooksForm = new IssuedBooksForm();
            issuedBooksForm.Show();
        }

        private void reportsListButton_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void UpdateStatusBar()
        {
            int booksCount = DatabaseHelper.GetCount("Books");
            toolStripStatusLabel1.Text = $" ÌË„: {booksCount}";

            int clientsCount = DatabaseHelper.GetCount("Clients");
            toolStripStatusLabel2.Text = $"◊ËÚ‡ÚÂÎÂÈ: {clientsCount}";

            int overdueCount = DatabaseHelper.GetCount("Issues WHERE ReturnDate IS NULL AND date(DueDate) < date('now')");
            toolStripStatusLabel3.Text = $"œÓÒÓ˜ÂÌÌ˚ı: {overdueCount}";
        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void ËÁÏÂÌËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBookForm editBookForm = new EditBookForm();
            editBookForm.ShowDialog();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBookForm deleteBookForm = new DeleteBookForm();
            deleteBookForm.ShowDialog();
        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
        }

        private void ËÁÏÂÌËÚ¸ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditClientForm editClientForm = new EditClientForm();
            editClientForm.ShowDialog();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteClientForm deleteClientForm = new DeleteClientForm();
            deleteClientForm.ShowDialog();
        }

        private void ‚˚‰‡Ú¸ ÌË„ÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.ShowDialog();
        }

        private void ÔËÌˇÚ¸ ÌË„ÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
        }

        private void ÔÓÔÛÎˇÌ˚Â ÌË„ËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopularBooksReportForm popularBooksReportForm = new PopularBooksReportForm();
            popularBooksReportForm.ShowDialog();
        }
    }
}
