using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingExamSheets
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();

        private bool isUpdate = false;
        public bool IsUpdate
        {
            get
            {
                return isUpdate;
            }

            set
            {
                isUpdate = value;
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            ListStudents.Items.Clear();
            ListStudents.Items.AddRange(db.Query("SELECT family, `name`, otchestvo FROM student ORDER BY family", 0, 2).ToArray());
            Accept.Enabled = false;
            Change.Enabled = false;
            Delete.Enabled = false;
        }

        private void ListStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListStudents.SelectedIndex != -1)
            {
                Accept.Enabled = true;
                Change.Enabled = true;
                Delete.Enabled = true;
            }
        }


        //Отправление ID-номера на родительскую форму
        private void Accept_Click(object sender, EventArgs e)
        {
            NewNote newNote = this.Owner as NewNote;
            if (newNote != null)
            {
                string [] name = ListStudents.SelectedItem.ToString().Split(' ');
                newNote.IDStudent = Convert.ToInt32(db.Query("SELECT id FROM student WHERE family='" + name[0] + "' AND `name`='" + name[1] + "' AND otchestvo='" + name[2] + "'")[0]);
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            ListStudents.Items.Clear();

            if (Search.Text != "")
            {
                ListStudents.Items.AddRange(db.Query("SELECT family, `name`, otchestvo FROM student WHERE family LIKE '" + Search.Text + "%' OR `name` LIKE '" + Search.Text + "%' OR otchestvo LIKE '" + Search.Text + "%'", 0, 2).ToArray());
            }
            else
            {
                ListStudents.Items.AddRange(db.Query("SELECT family, `name`, otchestvo FROM student ORDER BY family", 0, 2).ToArray());
            }
        }

        private void Students_Activated(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                ListStudents.Items.Clear();
                ListStudents.Items.AddRange(db.Query("SELECT family, `name`, otchestvo FROM student ORDER BY family", 0, 2).ToArray());
                Accept.Enabled = false;
                Change.Enabled = false;
                Delete.Enabled = false;
                IsUpdate = false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NewStudent newStud = new NewStudent();
            newStud.Owner = this;
            newStud.ShowDialog();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (ListStudents.SelectedIndex != -1)
            {
                string[] names = ListStudents.SelectedItem.ToString().Split(' ');
                string[] parts = db.Query("SELECT id, book, idFaculty, idGroup, idQuater, idCourse FROM student WHERE family='" + names[0] + "' AND `name`='" + names[1] + "' AND otchestvo='" + names[2] + "'", 0, 5)[0].Split(' ');
                string id = parts[0];
                NewStudent newStud = new NewStudent();
                newStud.Owner = this;

                newStud.Family.Text = names[0];
                newStud.FName.Text = names[1];
                newStud.Otchestvo.Text = names[2];

                newStud.Book.Text = parts[1];
                newStud.Faculty.Text = db.Query("SELECT title FROM faculty WHERE id=" + parts[2])[0];
                newStud.Group.Text = db.Query("SELECT `number` FROM `group` WHERE id=" + parts[3])[0];
                newStud.Quater.Text = db.Query("SELECT `number` FROM quater WHERE id=" + parts[4])[0];
                newStud.Course.Text = db.Query("SELECT `number` FROM course WHERE id=" + parts[5])[0];

                newStud.EditId = Convert.ToInt32(id);
                newStud.IsEdit = true;
                newStud.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ListStudents.SelectedIndex != -1)
            {
                string[] names = ListStudents.SelectedItem.ToString().Split(' ');
                string id = db.Query("SELECT id FROM student WHERE family='" + names[0] + "' AND `name`='" + names[1] + "' AND otchestvo='" + names[2] + "'")[0];
                db.ActionQuery("DELETE FROM sheet WHERE idStudent=" + id);
                db.ActionQuery("DELETE FROM student WHERE id=" + id);
                ListStudents.Items.Clear();
                ListStudents.Items.AddRange(db.Query("SELECT family, `name`, otchestvo FROM student ORDER BY family", 0, 2).ToArray());
                Accept.Enabled = false;
                Change.Enabled = false;
                Delete.Enabled = false;
            }
        }
    }
}
