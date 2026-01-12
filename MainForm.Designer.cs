using System.Drawing;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.популярныеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консольSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.booksListButton = new System.Windows.Forms.Button();
            this.clientsListButton = new System.Windows.Forms.Button();
            this.issuedBooksListButton = new System.Windows.Forms.Button();
            this.reportsListButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.выдачаToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // выдачаToolStripMenuItem
            // 
            this.выдачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выдатьКнигуToolStripMenuItem,
            this.принятьКнигуToolStripMenuItem});
            this.выдачаToolStripMenuItem.Name = "выдачаToolStripMenuItem";
            this.выдачаToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.выдачаToolStripMenuItem.Text = "Выдача";
            // 
            // выдатьКнигуToolStripMenuItem
            // 
            this.выдатьКнигуToolStripMenuItem.Name = "выдатьКнигуToolStripMenuItem";
            this.выдатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.выдатьКнигуToolStripMenuItem.Text = "Выдать книгу";
            this.выдатьКнигуToolStripMenuItem.Click += new System.EventHandler(this.выдатьКнигуToolStripMenuItem_Click);
            // 
            // принятьКнигуToolStripMenuItem
            // 
            this.принятьКнигуToolStripMenuItem.Name = "принятьКнигуToolStripMenuItem";
            this.принятьКнигуToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.принятьКнигуToolStripMenuItem.Text = "Принять книгу";
            this.принятьКнигуToolStripMenuItem.Click += new System.EventHandler(this.принятьКнигуToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.популярныеКнигиToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // популярныеКнигиToolStripMenuItem
            // 
            this.популярныеКнигиToolStripMenuItem.Name = "популярныеКнигиToolStripMenuItem";
            this.популярныеКнигиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.популярныеКнигиToolStripMenuItem.Text = "Популярные книги";
            this.популярныеКнигиToolStripMenuItem.Click += new System.EventHandler(this.популярныеКнигиToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.консольSQLToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // консольSQLToolStripMenuItem
            // 
            this.консольSQLToolStripMenuItem.Name = "консольSQLToolStripMenuItem";
            this.консольSQLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.консольSQLToolStripMenuItem.Text = "Консоль SQL";
            this.консольSQLToolStripMenuItem.Click += new System.EventHandler(this.консольSQLToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dateAndTimeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 50);
            this.panel1.TabIndex = 1;
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateAndTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateAndTimeLabel.Location = new System.Drawing.Point(0, 0);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(521, 50);
            this.dateAndTimeLabel.TabIndex = 0;
            this.dateAndTimeLabel.Text = "6 ноября 2025 10:41";
            this.dateAndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.booksListButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientsListButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.issuedBooksListButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reportsListButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 290);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // booksListButton
            // 
            this.booksListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksListButton.Font = new System.Drawing.Font("Sitka Banner", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksListButton.Location = new System.Drawing.Point(3, 3);
            this.booksListButton.Name = "booksListButton";
            this.booksListButton.Size = new System.Drawing.Size(200, 139);
            this.booksListButton.TabIndex = 0;
            this.booksListButton.Text = "📗Книги";
            this.booksListButton.UseVisualStyleBackColor = true;
            this.booksListButton.Click += new System.EventHandler(this.booksListButton_Click);
            // 
            // clientsListButton
            // 
            this.clientsListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsListButton.Font = new System.Drawing.Font("Sitka Banner", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsListButton.Location = new System.Drawing.Point(209, 3);
            this.clientsListButton.Name = "clientsListButton";
            this.clientsListButton.Size = new System.Drawing.Size(200, 139);
            this.clientsListButton.TabIndex = 1;
            this.clientsListButton.Text = "👤Клиенты";
            this.clientsListButton.UseVisualStyleBackColor = true;
            this.clientsListButton.Click += new System.EventHandler(this.clientsListButton_Click);
            // 
            // issuedBooksListButton
            // 
            this.issuedBooksListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuedBooksListButton.Font = new System.Drawing.Font("Sitka Banner", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issuedBooksListButton.Location = new System.Drawing.Point(3, 148);
            this.issuedBooksListButton.Name = "issuedBooksListButton";
            this.issuedBooksListButton.Size = new System.Drawing.Size(200, 139);
            this.issuedBooksListButton.TabIndex = 2;
            this.issuedBooksListButton.Text = "📝Выдачи";
            this.issuedBooksListButton.UseVisualStyleBackColor = true;
            this.issuedBooksListButton.Click += new System.EventHandler(this.issuedBooksListButton_Click);
            // 
            // reportsListButton
            // 
            this.reportsListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsListButton.Font = new System.Drawing.Font("Sitka Banner", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsListButton.Location = new System.Drawing.Point(209, 148);
            this.reportsListButton.Name = "reportsListButton";
            this.reportsListButton.Size = new System.Drawing.Size(200, 139);
            this.reportsListButton.TabIndex = 3;
            this.reportsListButton.Text = "📊Отчёты";
            this.reportsListButton.UseVisualStyleBackColor = true;
            this.reportsListButton.Click += new System.EventHandler(this.reportsListButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripStatusLabel1.Text = "Книг: 100";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripStatusLabel2.Text = "Читателей: 20";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(104, 22);
            this.toolStripStatusLabel3.Text = "Просроченных: 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(205, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблицы";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(521, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(537, 464);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта библиотеки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem книгиToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem1;
        private ToolStripMenuItem изменитьToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private ToolStripMenuItem выдачаToolStripMenuItem;
        private ToolStripMenuItem выдатьКнигуToolStripMenuItem;
        private ToolStripMenuItem принятьКнигуToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private ToolStripMenuItem популярныеКнигиToolStripMenuItem;
        private Panel panel1;
        private Label dateAndTimeLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button booksListButton;
        private Button clientsListButton;
        private Button issuedBooksListButton;
        private Button reportsListButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem консольSQLToolStripMenuItem;
    }
}
