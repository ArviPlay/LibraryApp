using System.Drawing;
using System.Windows.Forms;

namespace LibraryAppForProject
{
    partial class ReportsForm
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
            this.reportIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.reportIDColumn,
            this.reportNameColumn,
            this.periodColumn,
            this.generatedDateColumn,
            this.recordsCountColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(586, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // reportIDColumn
            // 
            this.reportIDColumn.HeaderText = "ID";
            this.reportIDColumn.Name = "reportIDColumn";
            this.reportIDColumn.ReadOnly = true;
            this.reportIDColumn.Width = 50;
            // 
            // reportNameColumn
            // 
            this.reportNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reportNameColumn.HeaderText = "Название";
            this.reportNameColumn.Name = "reportNameColumn";
            this.reportNameColumn.ReadOnly = true;
            // 
            // periodColumn
            // 
            this.periodColumn.HeaderText = "Период";
            this.periodColumn.Name = "periodColumn";
            this.periodColumn.ReadOnly = true;
            // 
            // generatedDateColumn
            // 
            this.generatedDateColumn.HeaderText = "Дата создания";
            this.generatedDateColumn.Name = "generatedDateColumn";
            this.generatedDateColumn.ReadOnly = true;
            // 
            // recordsCountColumn
            // 
            this.recordsCountColumn.HeaderText = "Кол-во записей";
            this.recordsCountColumn.Name = "recordsCountColumn";
            this.recordsCountColumn.ReadOnly = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 339);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(602, 378);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn reportIDColumn;
        private DataGridViewTextBoxColumn reportNameColumn;
        private DataGridViewTextBoxColumn periodColumn;
        private DataGridViewTextBoxColumn generatedDateColumn;
        private DataGridViewTextBoxColumn recordsCountColumn;
    }
}