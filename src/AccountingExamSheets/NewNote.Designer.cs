namespace AccountingExamSheets
{
    partial class NewNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNote));
            this.Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.SelectSubject = new System.Windows.Forms.Button();
            this.SelectExaminator = new System.Windows.Forms.Button();
            this.SelectStudent = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Group = new System.Windows.Forms.TextBox();
            this.Quater = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.TextBox();
            this.Faculty = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListExaminators = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KindValid = new System.Windows.Forms.ComboBox();
            this.ShowLists = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(191, 9);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 20);
            this.Count.TabIndex = 0;
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер экзаменационного листа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название предмета";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(135, 19);
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Size = new System.Drawing.Size(153, 20);
            this.Subject.TabIndex = 3;
            // 
            // SelectSubject
            // 
            this.SelectSubject.Location = new System.Drawing.Point(294, 19);
            this.SelectSubject.Name = "SelectSubject";
            this.SelectSubject.Size = new System.Drawing.Size(35, 20);
            this.SelectSubject.TabIndex = 4;
            this.SelectSubject.Text = "...";
            this.SelectSubject.UseVisualStyleBackColor = true;
            this.SelectSubject.Click += new System.EventHandler(this.SelectSubject_Click);
            // 
            // SelectExaminator
            // 
            this.SelectExaminator.Location = new System.Drawing.Point(294, 26);
            this.SelectExaminator.Name = "SelectExaminator";
            this.SelectExaminator.Size = new System.Drawing.Size(35, 20);
            this.SelectExaminator.TabIndex = 7;
            this.SelectExaminator.Text = "...";
            this.SelectExaminator.UseVisualStyleBackColor = true;
            this.SelectExaminator.Click += new System.EventHandler(this.SelectExaminator_Click);
            // 
            // SelectStudent
            // 
            this.SelectStudent.Location = new System.Drawing.Point(331, 33);
            this.SelectStudent.Name = "SelectStudent";
            this.SelectStudent.Size = new System.Drawing.Size(35, 20);
            this.SelectStudent.TabIndex = 10;
            this.SelectStudent.Text = "...";
            this.SelectStudent.UseVisualStyleBackColor = true;
            this.SelectStudent.Click += new System.EventHandler(this.SelectStudent_Click);
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(126, 33);
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            this.Student.Size = new System.Drawing.Size(199, 20);
            this.Student.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ФИО";
            // 
            // NumberBook
            // 
            this.NumberBook.Location = new System.Drawing.Point(126, 69);
            this.NumberBook.Name = "NumberBook";
            this.NumberBook.ReadOnly = true;
            this.NumberBook.Size = new System.Drawing.Size(55, 20);
            this.NumberBook.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "№ зачётной книжки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Факультет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Курс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Группа";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(674, 230);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 19;
            this.Accept.Text = "Готово";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Семестр";
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(366, 232);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(55, 20);
            this.Hours.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(363, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Количество часов";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Вид аттестации";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(593, 230);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Group);
            this.groupBox1.Controls.Add(this.Quater);
            this.groupBox1.Controls.Add(this.Course);
            this.groupBox1.Controls.Add(this.Faculty);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NumberBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SelectStudent);
            this.groupBox1.Controls.Add(this.Student);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(366, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 192);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студент";
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(270, 105);
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Size = new System.Drawing.Size(55, 20);
            this.Group.TabIndex = 45;
            // 
            // Quater
            // 
            this.Quater.Location = new System.Drawing.Point(270, 69);
            this.Quater.Name = "Quater";
            this.Quater.ReadOnly = true;
            this.Quater.Size = new System.Drawing.Size(55, 20);
            this.Quater.TabIndex = 44;
            // 
            // Course
            // 
            this.Course.Location = new System.Drawing.Point(126, 143);
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Size = new System.Drawing.Size(55, 20);
            this.Course.TabIndex = 42;
            // 
            // Faculty
            // 
            this.Faculty.Location = new System.Drawing.Point(126, 106);
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            this.Faculty.Size = new System.Drawing.Size(55, 20);
            this.Faculty.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectSubject);
            this.groupBox2.Controls.Add(this.Subject);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 52);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предмет";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListExaminators);
            this.groupBox3.Controls.Add(this.SelectExaminator);
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 101);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Экзаменаторы";
            // 
            // ListExaminators
            // 
            this.ListExaminators.ContextMenuStrip = this.contextMenuStrip1;
            this.ListExaminators.FormattingEnabled = true;
            this.ListExaminators.Location = new System.Drawing.Point(9, 26);
            this.ListExaminators.Name = "ListExaminators";
            this.ListExaminators.Size = new System.Drawing.Size(279, 56);
            this.ListExaminators.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "Удалить из списка";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // KindValid
            // 
            this.KindValid.FormattingEnabled = true;
            this.KindValid.Location = new System.Drawing.Point(219, 230);
            this.KindValid.Name = "KindValid";
            this.KindValid.Size = new System.Drawing.Size(128, 21);
            this.KindValid.TabIndex = 40;
            // 
            // ShowLists
            // 
            this.ShowLists.Image = global::AccountingExamSheets.Properties.Resources.lists;
            this.ShowLists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLists.Location = new System.Drawing.Point(12, 227);
            this.ShowLists.Name = "ShowLists";
            this.ShowLists.Size = new System.Drawing.Size(201, 25);
            this.ShowLists.TabIndex = 41;
            this.ShowLists.Text = "Открыть окно настроек списков";
            this.ShowLists.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowLists.UseVisualStyleBackColor = true;
            this.ShowLists.Click += new System.EventHandler(this.ShowLists_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 272);
            this.Controls.Add(this.ShowLists);
            this.Controls.Add(this.KindValid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Count);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый лист";
            this.Activated += new System.EventHandler(this.NewNote_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewNote_FormClosed);
            this.Load += new System.EventHandler(this.NewNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Button SelectSubject;
        private System.Windows.Forms.Button SelectExaminator;
        private System.Windows.Forms.Button SelectStudent;
        private System.Windows.Forms.TextBox Student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListExaminators;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.TextBox Quater;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.TextBox Faculty;
        private System.Windows.Forms.ComboBox KindValid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button ShowLists;

    }
}