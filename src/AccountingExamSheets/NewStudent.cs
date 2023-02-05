using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AccountingExamSheets
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();

        private bool isEdit = false;
        public bool IsEdit
        {
            get
            {
                return isEdit;
            }

            set
            {
                isEdit = value;
            }
        }

        private int editId = -1;
        public int EditId
        {
            get
            {
                return editId;
            }

            set
            {
                editId = value;
            }
        }

        private bool updateList = false;
        public bool UpdateList
        {
            get
            {
                return updateList;
            }

            set
            {
                updateList = value;
            }
        }





        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fresh()
        {
            Faculty.Items.AddRange(db.Query("SELECT title FROM faculty").ToArray());
            Course.Items.AddRange(db.Query("SELECT number FROM course").ToArray());
            Quater.Items.AddRange(db.Query("SELECT number FROM quater").ToArray());
            Group.Items.AddRange(db.Query("SELECT number FROM `group`").ToArray());

            IniEditor ini = new IniEditor();
            string item = ini.GetValue(Application.StartupPath + @"\settings.ini", "[Default]", "faculty");
            if (item != "")
            {
                Faculty.Text = item;
            }
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            Fresh();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (Family.Text != "" && FName.Text != "" && Otchestvo.Text != "" && IsNumber(Book.Text) && Faculty.Text != "" && Course.Text != "" && Quater.Text != "" && Group.Text != "")
            {
                string idFaculty = db.Query("SELECT id FROM faculty WHERE title='" + Faculty.Text + "'")[0];
                string idGroup = db.Query("SELECT id FROM `group` WHERE number='" + Group.Text + "'")[0];
                string idQuater = db.Query("SELECT id FROM quater WHERE number=" + Quater.Text)[0];
                string idCourse = db.Query("SELECT id FROM course WHERE number=" + Course.Text)[0];

                if (!IsEdit)
                {
                    db.ActionQuery("INSERT INTO student (family, `name`, otchestvo, book, idFaculty, idGroup, idQuater, idCourse) VALUES ('" + Family.Text + "', '" + FName.Text + "', '" + Otchestvo.Text + "', " + Book.Text + ", " + idFaculty + ", " + idGroup + ", " + idQuater + ", " + idCourse + ")");
                }
                else
                {
                    db.ActionQuery("UPDATE student SET family='" + Family.Text + "', `name`='" + FName.Text + "', otchestvo='" + Otchestvo.Text + "', book=" + Book.Text + ", idFaculty=" + idFaculty + ", idGroup=" + idGroup + ", idQuater=" + idQuater + ", idCourse=" + idCourse + " WHERE id=" + EditId);
                    IsEdit = false;
                }

                Students stud = this.Owner as Students;
                if (stud != null)
                {
                    stud.IsUpdate = true;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void Clean()
        {
            Family.Clear();
            FName.Clear();
            Otchestvo.Clear();
            Book.Clear();
            Faculty.Items.Clear();
            Course.Items.Clear();
            Quater.Items.Clear();
            Group.Items.Clear();
        }

        private void NewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clean();
        }

        private bool IsNumber(string number)
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists();
            lists.Owner = this;
            lists.ShowDialog();
        }

        private void NewStudent_Activated(object sender, EventArgs e)
        {
            if (UpdateList)
            {
                Clean();
                Fresh();
                UpdateList = false;
            }
        }
    }
}
