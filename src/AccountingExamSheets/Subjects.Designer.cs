namespace AccountingExamSheets
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.ListSubjects = new System.Windows.Forms.ListBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListSubjects
            // 
            this.ListSubjects.FormattingEnabled = true;
            this.ListSubjects.Location = new System.Drawing.Point(12, 54);
            this.ListSubjects.Name = "ListSubjects";
            this.ListSubjects.Size = new System.Drawing.Size(283, 355);
            this.ListSubjects.TabIndex = 0;
            this.ListSubjects.SelectedIndexChanged += new System.EventHandler(this.ListSubjects_SelectedIndexChanged);
            // 
            // Accept
            // 
            this.Accept.Enabled = false;
            this.Accept.Location = new System.Drawing.Point(220, 415);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 1;
            this.Accept.Text = "ОК";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(139, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Image = global::AccountingExamSheets.Properties.Resources.add;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(12, 23);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 25);
            this.Add.TabIndex = 3;
            this.Add.Text = "Добавить";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.Image = global::AccountingExamSheets.Properties.Resources.edit;
            this.Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change.Location = new System.Drawing.Point(102, 23);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(85, 25);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить";
            this.Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Image = global::AccountingExamSheets.Properties.Resources.delete;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(193, 23);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 25);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Удалить";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 451);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ListSubjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор предмета";
            this.Activated += new System.EventHandler(this.Subjects_Activated);
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListSubjects;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
    }
}