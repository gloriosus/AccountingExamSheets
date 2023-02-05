namespace AccountingExamSheets
{
    partial class Examinators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examinators));
            this.ListExaminators = new System.Windows.Forms.ListBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListExaminators
            // 
            this.ListExaminators.FormattingEnabled = true;
            this.ListExaminators.Location = new System.Drawing.Point(16, 68);
            this.ListExaminators.Name = "ListExaminators";
            this.ListExaminators.Size = new System.Drawing.Size(283, 355);
            this.ListExaminators.TabIndex = 0;
            this.ListExaminators.SelectedIndexChanged += new System.EventHandler(this.ListExaminators_SelectedIndexChanged);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(224, 429);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 1;
            this.Accept.Text = "ОК";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(143, 429);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(61, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(164, 20);
            this.Search.TabIndex = 3;
            // 
            // Find
            // 
            this.Find.Image = global::AccountingExamSheets.Properties.Resources.search;
            this.Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Find.Location = new System.Drawing.Point(231, 38);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(68, 25);
            this.Find.TabIndex = 4;
            this.Find.Text = "Найти";
            this.Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск";
            // 
            // Add
            // 
            this.Add.Image = global::AccountingExamSheets.Properties.Resources.add;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(16, 10);
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
            this.Change.Location = new System.Drawing.Point(106, 10);
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
            this.Delete.Location = new System.Drawing.Point(197, 10);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 25);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Удалить";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Examinators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 462);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ListExaminators);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Examinators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор экзаменатора";
            this.Activated += new System.EventHandler(this.Examinators_Activated);
            this.Load += new System.EventHandler(this.Examinators_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListExaminators;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
    }
}