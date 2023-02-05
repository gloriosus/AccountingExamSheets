namespace AccountingExamSheets
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.ListStudents = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListStudents
            // 
            this.ListStudents.FormattingEnabled = true;
            this.ListStudents.Location = new System.Drawing.Point(15, 78);
            this.ListStudents.Name = "ListStudents";
            this.ListStudents.Size = new System.Drawing.Size(283, 355);
            this.ListStudents.TabIndex = 0;
            this.ListStudents.SelectedIndexChanged += new System.EventHandler(this.ListStudents_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(60, 50);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(164, 20);
            this.Search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // Find
            // 
            this.Find.Image = global::AccountingExamSheets.Properties.Resources.search;
            this.Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Find.Location = new System.Drawing.Point(230, 47);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(68, 25);
            this.Find.TabIndex = 3;
            this.Find.Text = "Найти";
            this.Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Accept
            // 
            this.Accept.Enabled = false;
            this.Accept.Location = new System.Drawing.Point(223, 440);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "ОК";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(142, 440);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Image = global::AccountingExamSheets.Properties.Resources.add;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(18, 17);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 25);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добавить";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.Image = global::AccountingExamSheets.Properties.Resources.edit;
            this.Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change.Location = new System.Drawing.Point(108, 17);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(85, 25);
            this.Change.TabIndex = 7;
            this.Change.Text = "Изменить";
            this.Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Image = global::AccountingExamSheets.Properties.Resources.delete;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(199, 17);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 25);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Удалить";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 473);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ListStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор студента";
            this.Activated += new System.EventHandler(this.Students_Activated);
            this.Load += new System.EventHandler(this.Students_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListStudents;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
    }
}