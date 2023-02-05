namespace AccountingExamSheets
{
    partial class Lists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lists));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteValid = new System.Windows.Forms.Button();
            this.DeleteCourse = new System.Windows.Forms.Button();
            this.DeleteQuater = new System.Windows.Forms.Button();
            this.DeleteGroup = new System.Windows.Forms.Button();
            this.DeleteFaculty = new System.Windows.Forms.Button();
            this.KindValid = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.Quater = new System.Windows.Forms.ComboBox();
            this.Group = new System.Windows.Forms.ComboBox();
            this.Faculty = new System.Windows.Forms.ComboBox();
            this.AddValid = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.Button();
            this.AddQuater = new System.Windows.Forms.Button();
            this.AddGroup = new System.Windows.Forms.Button();
            this.AddFaculty = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факультет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Семестр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Курс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вид аттестации";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteValid);
            this.groupBox1.Controls.Add(this.DeleteCourse);
            this.groupBox1.Controls.Add(this.DeleteQuater);
            this.groupBox1.Controls.Add(this.DeleteGroup);
            this.groupBox1.Controls.Add(this.DeleteFaculty);
            this.groupBox1.Controls.Add(this.KindValid);
            this.groupBox1.Controls.Add(this.Course);
            this.groupBox1.Controls.Add(this.Quater);
            this.groupBox1.Controls.Add(this.Group);
            this.groupBox1.Controls.Add(this.Faculty);
            this.groupBox1.Controls.Add(this.AddValid);
            this.groupBox1.Controls.Add(this.AddCourse);
            this.groupBox1.Controls.Add(this.AddQuater);
            this.groupBox1.Controls.Add(this.AddGroup);
            this.groupBox1.Controls.Add(this.AddFaculty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 286);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление элементов";
            // 
            // DeleteValid
            // 
            this.DeleteValid.Location = new System.Drawing.Point(230, 238);
            this.DeleteValid.Name = "DeleteValid";
            this.DeleteValid.Size = new System.Drawing.Size(75, 23);
            this.DeleteValid.TabIndex = 23;
            this.DeleteValid.Text = "Удалить";
            this.DeleteValid.UseVisualStyleBackColor = true;
            this.DeleteValid.Click += new System.EventHandler(this.DeleteValid_Click);
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.Location = new System.Drawing.Point(230, 186);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Size = new System.Drawing.Size(75, 23);
            this.DeleteCourse.TabIndex = 22;
            this.DeleteCourse.Text = "Удалить";
            this.DeleteCourse.UseVisualStyleBackColor = true;
            this.DeleteCourse.Click += new System.EventHandler(this.DeleteCourse_Click);
            // 
            // DeleteQuater
            // 
            this.DeleteQuater.Location = new System.Drawing.Point(230, 137);
            this.DeleteQuater.Name = "DeleteQuater";
            this.DeleteQuater.Size = new System.Drawing.Size(75, 23);
            this.DeleteQuater.TabIndex = 21;
            this.DeleteQuater.Text = "Удалить";
            this.DeleteQuater.UseVisualStyleBackColor = true;
            this.DeleteQuater.Click += new System.EventHandler(this.DeleteQuater_Click);
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.Location = new System.Drawing.Point(230, 81);
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.DeleteGroup.TabIndex = 20;
            this.DeleteGroup.Text = "Удалить";
            this.DeleteGroup.UseVisualStyleBackColor = true;
            this.DeleteGroup.Click += new System.EventHandler(this.DeleteGroup_Click);
            // 
            // DeleteFaculty
            // 
            this.DeleteFaculty.Location = new System.Drawing.Point(230, 35);
            this.DeleteFaculty.Name = "DeleteFaculty";
            this.DeleteFaculty.Size = new System.Drawing.Size(75, 23);
            this.DeleteFaculty.TabIndex = 19;
            this.DeleteFaculty.Text = "Удалить";
            this.DeleteFaculty.UseVisualStyleBackColor = true;
            this.DeleteFaculty.Click += new System.EventHandler(this.DeleteFaculty_Click);
            // 
            // KindValid
            // 
            this.KindValid.FormattingEnabled = true;
            this.KindValid.Location = new System.Drawing.Point(22, 240);
            this.KindValid.Name = "KindValid";
            this.KindValid.Size = new System.Drawing.Size(121, 21);
            this.KindValid.TabIndex = 18;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(22, 188);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(121, 21);
            this.Course.TabIndex = 17;
            // 
            // Quater
            // 
            this.Quater.FormattingEnabled = true;
            this.Quater.Location = new System.Drawing.Point(22, 139);
            this.Quater.Name = "Quater";
            this.Quater.Size = new System.Drawing.Size(121, 21);
            this.Quater.TabIndex = 16;
            // 
            // Group
            // 
            this.Group.FormattingEnabled = true;
            this.Group.Location = new System.Drawing.Point(22, 86);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(121, 21);
            this.Group.TabIndex = 15;
            // 
            // Faculty
            // 
            this.Faculty.FormattingEnabled = true;
            this.Faculty.Location = new System.Drawing.Point(22, 37);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(121, 21);
            this.Faculty.TabIndex = 2;
            // 
            // AddValid
            // 
            this.AddValid.Location = new System.Drawing.Point(149, 238);
            this.AddValid.Name = "AddValid";
            this.AddValid.Size = new System.Drawing.Size(75, 23);
            this.AddValid.TabIndex = 14;
            this.AddValid.Text = "Добавить";
            this.AddValid.UseVisualStyleBackColor = true;
            this.AddValid.Click += new System.EventHandler(this.AddValid_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(149, 186);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(75, 23);
            this.AddCourse.TabIndex = 13;
            this.AddCourse.Text = "Добавить";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // AddQuater
            // 
            this.AddQuater.Location = new System.Drawing.Point(149, 137);
            this.AddQuater.Name = "AddQuater";
            this.AddQuater.Size = new System.Drawing.Size(75, 23);
            this.AddQuater.TabIndex = 12;
            this.AddQuater.Text = "Добавить";
            this.AddQuater.UseVisualStyleBackColor = true;
            this.AddQuater.Click += new System.EventHandler(this.AddQuater_Click);
            // 
            // AddGroup
            // 
            this.AddGroup.Location = new System.Drawing.Point(149, 81);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(75, 23);
            this.AddGroup.TabIndex = 11;
            this.AddGroup.Text = "Добавить";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // AddFaculty
            // 
            this.AddFaculty.Location = new System.Drawing.Point(149, 35);
            this.AddFaculty.Name = "AddFaculty";
            this.AddFaculty.Size = new System.Drawing.Size(75, 23);
            this.AddFaculty.TabIndex = 10;
            this.AddFaculty.Text = "Добавить";
            this.AddFaculty.UseVisualStyleBackColor = true;
            this.AddFaculty.Click += new System.EventHandler(this.AddFaculty_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(257, 309);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Закрыть";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 344);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка списков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lists_FormClosed);
            this.Load += new System.EventHandler(this.Lists_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddValid;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button AddQuater;
        private System.Windows.Forms.Button AddGroup;
        private System.Windows.Forms.Button AddFaculty;
        private System.Windows.Forms.ComboBox KindValid;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.ComboBox Quater;
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.ComboBox Faculty;
        private System.Windows.Forms.Button DeleteValid;
        private System.Windows.Forms.Button DeleteCourse;
        private System.Windows.Forms.Button DeleteQuater;
        private System.Windows.Forms.Button DeleteGroup;
        private System.Windows.Forms.Button DeleteFaculty;
        private System.Windows.Forms.Button Cancel;
    }
}