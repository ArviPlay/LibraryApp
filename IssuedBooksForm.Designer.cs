using System.Drawing;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    partial class IssuedBooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issueIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueIDColumn,
            this.clientIDColumn,
            this.clientNameColumn,
            this.bookIDColumn,
            this.bookNameColumn,
            this.borrowDateColumn,
            this.dueDateColumn,
            this.returnDateColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(744, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // issueIDColumn
            // 
            this.issueIDColumn.HeaderText = "ID выдачи";
            this.issueIDColumn.Name = "issueIDColumn";
            this.issueIDColumn.ReadOnly = true;
            this.issueIDColumn.Width = 65;
            // 
            // clientIDColumn
            // 
            this.clientIDColumn.HeaderText = "ID";
            this.clientIDColumn.Name = "clientIDColumn";
            this.clientIDColumn.ReadOnly = true;
            this.clientIDColumn.Width = 50;
            // 
            // clientNameColumn
            // 
            this.clientNameColumn.HeaderText = "Имя клиента";
            this.clientNameColumn.Name = "clientNameColumn";
            this.clientNameColumn.ReadOnly = true;
            this.clientNameColumn.Width = 120;
            // 
            // bookIDColumn
            // 
            this.bookIDColumn.HeaderText = "ID";
            this.bookIDColumn.Name = "bookIDColumn";
            this.bookIDColumn.ReadOnly = true;
            this.bookIDColumn.Width = 50;
            // 
            // bookNameColumn
            // 
            this.bookNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookNameColumn.HeaderText = "Название книги";
            this.bookNameColumn.Name = "bookNameColumn";
            this.bookNameColumn.ReadOnly = true;
            // 
            // borrowDateColumn
            // 
            this.borrowDateColumn.HeaderText = "Дата выдачи";
            this.borrowDateColumn.Name = "borrowDateColumn";
            this.borrowDateColumn.ReadOnly = true;
            // 
            // dueDateColumn
            // 
            this.dueDateColumn.HeaderText = "Срок возврата";
            this.dueDateColumn.Name = "dueDateColumn";
            this.dueDateColumn.ReadOnly = true;
            // 
            // returnDateColumn
            // 
            this.returnDateColumn.HeaderText = "Дата возврата";
            this.returnDateColumn.Name = "returnDateColumn";
            this.returnDateColumn.ReadOnly = true;
            // 
            // IssuedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 411);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(760, 450);
            this.Name = "IssuedBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдачи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn issueIDColumn;
        private DataGridViewTextBoxColumn clientIDColumn;
        private DataGridViewTextBoxColumn clientNameColumn;
        private DataGridViewTextBoxColumn bookIDColumn;
        private DataGridViewTextBoxColumn bookNameColumn;
        private DataGridViewTextBoxColumn borrowDateColumn;
        private DataGridViewTextBoxColumn dueDateColumn;
        private DataGridViewTextBoxColumn returnDateColumn;
    }
}