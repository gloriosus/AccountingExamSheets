namespace AccountingExamSheets
{
    partial class Journal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PrintContext = new System.Windows.Forms.ToolStripMenuItem();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.LastPage = new System.Windows.Forms.TextBox();
            this.Page = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.Context.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.date,
            this.student,
            this.group,
            this.subject,
            this.examinator});
            this.DataGrid.ContextMenuStrip = this.Context;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(660, 418);
            this.DataGrid.TabIndex = 0;
            // 
            // number
            // 
            this.number.HeaderText = "№ п/п";
            this.number.Name = "number";
            // 
            // date
            // 
            this.date.HeaderText = "Дата выдачи";
            this.date.Name = "date";
            // 
            // student
            // 
            this.student.HeaderText = "Ф.И.О. студента";
            this.student.Name = "student";
            // 
            // group
            // 
            this.group.HeaderText = "№ группы";
            this.group.Name = "group";
            // 
            // subject
            // 
            this.subject.HeaderText = "Название дисциплины";
            this.subject.Name = "subject";
            // 
            // examinator
            // 
            this.examinator.HeaderText = "Ф.И.О. преподавателя";
            this.examinator.Name = "examinator";
            // 
            // Context
            // 
            this.Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintContext});
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(114, 26);
            // 
            // PrintContext
            // 
            this.PrintContext.Name = "PrintContext";
            this.PrintContext.Size = new System.Drawing.Size(113, 22);
            this.PrintContext.Text = "Печать";
            this.PrintContext.Click += new System.EventHandler(this.PrintContext_Click);
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(174, 381);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(36, 28);
            this.Prev.TabIndex = 1;
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(331, 381);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(36, 28);
            this.Next.TabIndex = 2;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // LastPage
            // 
            this.LastPage.Location = new System.Drawing.Point(286, 386);
            this.LastPage.Name = "LastPage";
            this.LastPage.ReadOnly = true;
            this.LastPage.Size = new System.Drawing.Size(39, 20);
            this.LastPage.TabIndex = 3;
            this.LastPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(216, 386);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(39, 20);
            this.Page.TabIndex = 4;
            this.Page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Page.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "из";
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(132, 381);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(36, 28);
            this.First.TabIndex = 6;
            this.First.UseVisualStyleBackColor = true;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(373, 381);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(36, 28);
            this.Last.TabIndex = 7;
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.First);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.LastPage);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.DataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.Journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.Context.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinator;
        private System.Windows.Forms.ContextMenuStrip Context;
        private System.Windows.Forms.ToolStripMenuItem PrintContext;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox LastPage;
        private System.Windows.Forms.TextBox Page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button button2;
    }
}