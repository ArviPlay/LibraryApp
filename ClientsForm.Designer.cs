using System.Drawing;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    partial class ClientsForm
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
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.idColumn,
            this.fullNameColumn,
            this.phoneNumberColumn,
            this.birthDateColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(586, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameColumn.HeaderText = "ФИО";
            this.fullNameColumn.Name = "fullNameColumn";
            this.fullNameColumn.ReadOnly = true;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.HeaderText = "Номер телефона";
            this.phoneNumberColumn.Name = "phoneNumberColumn";
            this.phoneNumberColumn.ReadOnly = true;
            this.phoneNumberColumn.Width = 150;
            // 
            // birthDateColumn
            // 
            this.birthDateColumn.HeaderText = "Дата рождения";
            this.birthDateColumn.Name = "birthDateColumn";
            this.birthDateColumn.ReadOnly = true;
            this.birthDateColumn.Width = 150;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 339);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(602, 378);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn fullNameColumn;
        private DataGridViewTextBoxColumn phoneNumberColumn;
        private DataGridViewTextBoxColumn birthDateColumn;
    }
}