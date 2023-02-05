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
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();

        private void Lists_Load(object sender, EventArgs e)
        {
            Faculty.Items.AddRange(db.Query("SELECT title FROM faculty").ToArray());
            Group.Items.AddRange(db.Query("SELECT `number` FROM `group`").ToArray());
            Quater.Items.AddRange(db.Query("SELECT `number` FROM quater").ToArray());
            Course.Items.AddRange(db.Query("SELECT `number` FROM course").ToArray());
            KindValid.Items.AddRange(db.Query("SELECT kind FROM validation").ToArray());
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

        private void AddFaculty_Click(object sender, EventArgs e)
        {
            if (Faculty.Text.Trim() != "")
            {
                if (!Faculty.Items.Contains(Faculty.Text))
                {
                    try
                    {
                        db.ActionQuery("INSERT INTO faculty (title) VALUES ('" + Faculty.Text + "')");
                        MessageBox.Show("Факультет \"" + Faculty.Text + "\" успешно внесен в базу");
                        Faculty.Items.Clear();
                        Faculty.Items.AddRange(db.Query("SELECT title FROM faculty").ToArray());
                        Faculty.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при внесении новой записи");
                    }
                }
                else
                {
                    MessageBox.Show("\"" + Faculty.Text + "\" уже существует в базе");
                }
            }
            else
            {
                MessageBox.Show("Введите название факультета");
            }
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            if (Group.Text.Trim() != "")
            {
                if (!Group.Items.Contains(Group.Text))
                {
                    try
                    {
                        db.ActionQuery("INSERT INTO `group` (`number`) VALUES ('" + Group.Text + "')");
                        MessageBox.Show("Группа \"" + Group.Text + "\" успешно внесена в базу");
                        Group.Items.Clear();
                        Group.Items.AddRange(db.Query("SELECT `number` FROM `group`").ToArray());
                        Group.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при внесении новой записи");
                    }
                }
                else
                {
                    MessageBox.Show("\"" + Group.Text + "\" уже существует в базе");
                }
            }
            else
            {
                MessageBox.Show("Введите номер группы");
            }
        }

        private void AddQuater_Click(object sender, EventArgs e)
        {
            if (IsNumber(Quater.Text))
            {
                if (!Quater.Items.Contains(Quater.Text))
                {
                    try
                    {
                        db.ActionQuery("INSERT INTO quater (`number`) VALUES (" + Quater.Text + ")");
                        MessageBox.Show("Семестр \"" + Quater.Text + "\" успешно внесен в базу");
                        Quater.Items.Clear();
                        Quater.Items.AddRange(db.Query("SELECT `number` FROM quater").ToArray());
                        Quater.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при внесении новой записи");
                    }
                }
                else
                {
                    MessageBox.Show("\"" + Quater.Text + "\" уже существует в базе");
                }
            }
            else
            {
                MessageBox.Show("Введите номер семестра");
            }
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            if (IsNumber(Course.Text))
            {
                if (!Course.Items.Contains(Course.Text))
                {
                    try
                    {
                        db.ActionQuery("INSERT INTO course (`number`) VALUES (" + Course.Text + ")");
                        MessageBox.Show("Курс \"" + Course.Text + "\" успешно внесен в базу");
                        Course.Items.Clear();
                        Course.Items.AddRange(db.Query("SELECT `number` FROM course").ToArray());
                        Course.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при внесении новой записи");
                    }
                }
                else
                {
                    MessageBox.Show("\"" + Course.Text + "\" уже существует в базе");
                }
            }
            else
            {
                MessageBox.Show("Введите номер курса");
            }
        }

        private void AddValid_Click(object sender, EventArgs e)
        {
            if (KindValid.Text.Trim() != "")
            {
                if (!KindValid.Items.Contains(KindValid.Text))
                {
                    try
                    {
                        db.ActionQuery("INSERT INTO validation (kind) VALUES ('" + KindValid.Text + "')");
                        MessageBox.Show("Вид аттестации \"" + KindValid.Text + "\" успешно внесен в базу");
                        KindValid.Items.Clear();
                        KindValid.Items.AddRange(db.Query("SELECT kind FROM validation").ToArray());
                        KindValid.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при внесении новой записи");
                    }
                }
                else
                {
                    MessageBox.Show("\"" + KindValid.Text + "\" уже существует в базе");
                }
            }
            else
            {
                MessageBox.Show("Введите название вида аттестации");
            }
        }




        private void DeleteFaculty_Click(object sender, EventArgs e)
        {
            if (Faculty.SelectedIndex != -1)
            {
                try
                {
                    db.ActionQuery("DELETE FROM sheet WHERE idStudent in (SELECT id FROM student WHERE idFaculty in (SELECT id FROM faculty WHERE title='" + Faculty.Text + "'))");
                    db.ActionQuery("DELETE FROM student WHERE idFaculty in (SELECT id FROM faculty WHERE title='" + Faculty.Text + "')");
                    db.ActionQuery("DELETE FROM faculty WHERE title='" + Faculty.Text + "'");
                    MessageBox.Show("Факультет \"" + Faculty.Text + "\" успешно удален из базы");
                    Faculty.Items.Clear();
                    Faculty.Items.AddRange(db.Query("SELECT title FROM faculty").ToArray());
                    Faculty.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении записи");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
            if (Group.SelectedIndex != -1)
            {
                try
                {
                    db.ActionQuery("DELETE FROM sheet WHERE idStudent in (SELECT id FROM student WHERE idGroup in (SELECT id FROM `group` WHERE `number`='" + Group.Text + "'))");
                    db.ActionQuery("DELETE FROM student WHERE idGroup in (SELECT id FROM `group` WHERE `number`='" + Group.Text + "')");
                    db.ActionQuery("DELETE FROM `group` WHERE `number`='" + Group.Text + "'");
                    MessageBox.Show("Группа \"" + Group.Text + "\" успешно удалена из базы");
                    Group.Items.Clear();
                    Group.Items.AddRange(db.Query("SELECT `number` FROM `group`").ToArray());
                    Group.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении записи");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void DeleteQuater_Click(object sender, EventArgs e)
        {
            if (Quater.SelectedIndex != -1)
            {
                try
                {
                    db.ActionQuery("DELETE FROM sheet WHERE idStudent in (SELECT id FROM student WHERE idQuater in (SELECT id FROM quater WHERE `number`=" + Quater.Text + "))");
                    db.ActionQuery("DELETE FROM student WHERE idQuater in (SELECT id FROM quater WHERE `number`=" + Quater.Text + ")");
                    db.ActionQuery("DELETE FROM quater WHERE `number`=" + Quater.Text);
                    MessageBox.Show("Семестр \"" + Quater.Text + "\" успешно удален из базы");
                    Quater.Items.Clear();
                    Quater.Items.AddRange(db.Query("SELECT `number` FROM quater").ToArray());
                    Quater.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении записи");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void DeleteCourse_Click(object sender, EventArgs e)
        {
            if (Course.SelectedIndex != -1)
            {
                try
                {
                    db.ActionQuery("DELETE FROM sheet WHERE idStudent in (SELECT id FROM student WHERE idCourse in (SELECT id FROM course WHERE `number`=" + Course.Text + "))");
                    db.ActionQuery("DELETE FROM student WHERE idCourse in (SELECT id FROM course WHERE `number`=" + Course.Text + ")");
                    db.ActionQuery("DELETE FROM course WHERE `number`=" + Course.Text);
                    MessageBox.Show("Курс \"" + Course.Text + "\" успешно удален из базы");
                    Course.Items.Clear();
                    Course.Items.AddRange(db.Query("SELECT `number` FROM course").ToArray());
                    Course.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении записи");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void DeleteValid_Click(object sender, EventArgs e)
        {
            if (KindValid.SelectedIndex != -1)
            {
                try
                {
                    db.ActionQuery("DELETE FROM sheet WHERE idValid in (SELECT id FROM validation WHERE kind='" + KindValid.Text + "')");
                    db.ActionQuery("DELETE FROM validation WHERE kind='" + KindValid.Text + "'");
                    MessageBox.Show("Вид аттестации \"" + KindValid.Text + "\" успешно удален из базы");
                    KindValid.Items.Clear();
                    KindValid.Items.AddRange(db.Query("SELECT kind FROM validation").ToArray());
                    KindValid.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении записи");
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lists_FormClosed(object sender, FormClosedEventArgs e)
        {
            NewStudent stud = this.Owner as NewStudent;
            if (stud != null)
            {
                stud.UpdateList = true;
            }

            NewNote note = this.Owner as NewNote;
            if(note != null)
            {
                note.IsFresh = true;
            }
        }
    }
}
